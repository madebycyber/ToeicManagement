document.addEventListener('DOMContentLoaded', function() {
    // --- Elements ---
    const sidebar = document.getElementById('sidebar');
    const sidebarToggle = document.getElementById('sidebar-toggle');
    const sidebarOpenMobile = document.getElementById('sidebar-open-mobile');
    const sidebarCloseMobile = document.getElementById('sidebar-close-mobile');
    const modalOverlay = document.getElementById('modal-overlay');

    const materialListView = document.getElementById('material-list-view');
    const materialFormView = document.getElementById('material-form-view');
    const materialForm = document.getElementById('material-form');
    const materialFormTitle = document.getElementById('material-form-title-heading');
    const materialIdInput = document.getElementById('material-id');
    
    const materialTypeFormSelect = document.getElementById('material-type-form');
    const fileUploadSection = document.getElementById('file-upload-section');
    const materialFileInput = document.getElementById('material-file');
    const currentFileInfo = document.getElementById('current-file-info');
    const currentFileLink = document.getElementById('current-file-link');
    const linkInputSection = document.getElementById('link-input-section');
    const materialLinkInput = document.getElementById('material-link');
    const textContentSection = document.getElementById('text-content-section');
    const materialTextContentInput = document.getElementById('material-text-content');
    const adminStatusSectionForm = document.getElementById('admin-status-section-form');


    const saveMaterialBtn = document.getElementById('save-material-btn');
    const materialsTableBody = document.getElementById('materials-table-body');
    
    const paginationInfo = document.getElementById('pagination-info');
    const prevPageBtn = document.getElementById('prev-page');
    const nextPageBtn = document.getElementById('next-page');
    const currentPageDisplay = document.getElementById('current-page-display');
    const rowsFilterSelect = document.getElementById('rows-filter');


    let currentPage = 1;
    let rowsPerPage = parseInt(rowsFilterSelect.value) || 10;

    const currentUserRole = 'admin'; 
    const currentUserId = 'user123'; 

    // --- Sidebar Logic ---
    if (sidebarToggle && sidebar) {
        sidebarToggle.addEventListener('click', () => sidebar.classList.toggle('collapsed'));
    }
    if (sidebarOpenMobile && sidebar) {
        sidebarOpenMobile.addEventListener('click', () => sidebar.classList.add('open'));
    }
    if (sidebarCloseMobile && sidebar) {
        sidebarCloseMobile.addEventListener('click', () => sidebar.classList.remove('open'));
    }
    if (modalOverlay) {
         modalOverlay.addEventListener('click', () => {
             if (sidebar && sidebar.classList.contains('open')) {
                 sidebar.classList.remove('open');
             }
             closeAllModals();
         });
    }

    // --- View Management ---
    window.showMaterialListView = function() {
        if (materialListView) materialListView.classList.remove('hidden');
        if (materialFormView) materialFormView.classList.add('hidden');
        loadMaterials(currentPage);
        closeAllModals();
    }

    window.showMaterialFormView = function(materialId = null) {
        if (materialListView) materialListView.classList.add('hidden');
        if (materialFormView) materialFormView.classList.remove('hidden');
        if (!materialForm || !materialFormTitle || !materialIdInput || !saveMaterialBtn || !materialFileInput || !currentFileInfo || !currentFileLink || !materialTypeFormSelect) {
            console.error("Một số element của form tài liệu không tìm thấy.");
            return;
        }

        materialForm.reset();
        materialIdInput.value = '';
        currentFileInfo.classList.add('hidden');
        currentFileLink.href = '#';
        currentFileLink.textContent = '';
        materialFileInput.value = ''; 
        materialLinkInput.value = '';
        materialTextContentInput.value = '';
        updateDynamicFormFields(); 

        if (currentUserRole === 'admin' && adminStatusSectionForm) {
            adminStatusSectionForm.classList.remove('hidden');
        } else if (adminStatusSectionForm) {
            adminStatusSectionForm.classList.add('hidden');
        }


        if (materialId) {
            materialFormTitle.innerText = 'Chỉnh sửa Tài liệu học tập';
            saveMaterialBtn.innerText = 'Cập nhật Tài liệu';
            
            fetchMaterialDetails(materialId)
                .then(data => {
                    if (!data) {
                        alert("Không tìm thấy dữ liệu tài liệu.");
                        showMaterialListView();
                        return;
                    }
                    materialIdInput.value = data.id;
                    document.getElementById('material-title').value = data.title || '';
                    document.getElementById('material-description').value = data.description || '';
                    materialTypeFormSelect.value = data.materialType || ""; 
                    updateDynamicFormFields(); 

                    if (data.materialType === 'video_link' || data.materialType === 'audio_link' || data.materialType === 'external_link') {
                        materialLinkInput.value = data.link || '';
                    }
                    if (data.materialType === 'other_text') {
                        materialTextContentInput.value = data.textContent || '';
                    }

                    if (data.filePath && (data.materialType === 'pdf' || data.materialType === 'docx' || data.materialType === 'video_file' || data.materialType === 'audio_file')) {
                        currentFileInfo.classList.remove('hidden');
                        currentFileLink.href = data.filePath; 
                        currentFileLink.textContent = data.fileName || 'Xem tệp hiện tại';
                        materialFileInput.required = false; 
                    } else {
                         // Requirement will be set by updateDynamicFormFields if it's a file type
                    }
                    
                    document.getElementById('material-category').value = data.categoryId || '';
                    document.getElementById('general-material-type-filter').value = data.generalTypeId || ''; 
                    document.getElementById('material-tags').value = data.tags ? data.tags.join(', ') : '';
                    
                    if (currentUserRole === 'admin' && document.getElementById('material-status-admin')) {
                        document.getElementById('material-status-admin').value = data.status || 'pending';
                    }
                })
                .catch(err => {
                    console.error("Lỗi tải chi tiết tài liệu:", err);
                    alert("Lỗi tải dữ liệu tài liệu.");
                    showMaterialListView();
                });
        } else {
            materialFormTitle.innerText = 'Thêm mới Tài liệu học tập';
            saveMaterialBtn.innerText = 'Lưu & Gửi duyệt';
            updateDynamicFormFields();
        }
    }
    
    if (materialTypeFormSelect) {
        materialTypeFormSelect.addEventListener('change', updateDynamicFormFields);
    }

    function updateDynamicFormFields() {
        const selectedType = materialTypeFormSelect.value;
        fileUploadSection.classList.add('hidden');
        linkInputSection.classList.add('hidden');
        textContentSection.classList.add('hidden');
        materialFileInput.required = false;
        materialLinkInput.required = false;
        materialTextContentInput.required = false;

        if (selectedType === 'pdf' || selectedType === 'docx' || selectedType === 'video_file' || selectedType === 'audio_file') {
            fileUploadSection.classList.remove('hidden');
            // Only require file if adding new, or if editing and no current file exists for file-based types
            const isEditing = !!materialIdInput.value;
            const hasCurrentFile = currentFileLink.href && currentFileLink.href !== '#' && currentFileLink.href !== window.location.href + '#';
            if (!isEditing || (isEditing && !hasCurrentFile) ) {
                 materialFileInput.required = true;
            }
        } else if (selectedType === 'video_link' || selectedType === 'audio_link' || selectedType === 'external_link') {
            linkInputSection.classList.remove('hidden');
            materialLinkInput.required = true;
        } else if (selectedType === 'other_text') {
            textContentSection.classList.remove('hidden');
            materialTextContentInput.required = true;
        }
    }

    // --- Modal Management ---
    window.showMaterialDetailModal = function(materialId) {
        const modal = document.getElementById('material-detail-modal');
        const modalBody = document.getElementById('material-detail-modal-body');
        const modalTitle = document.getElementById('material-detail-modal-title');

        if (modal && modalBody && modalTitle && modalOverlay) {
            modalTitle.textContent = `Chi tiết Tài liệu #${materialId}`;
            modalBody.innerHTML = '<p>Đang tải chi tiết...</p>';
            openModal('material-detail-modal');

            fetchMaterialDetails(materialId).then(data => {
                if (!data) {
                    modalBody.innerHTML = '<p style="color:red;">Không tìm thấy thông tin tài liệu.</p>';
                    return;
                }
                let contentHtml = `
                    <div class="detail-section"><span class="detail-label">Tiêu đề:</span> ${escapeHtml(data.title || 'N/A')}</div>
                    <div class="detail-section"><span class="detail-label">Mô tả:</span> ${escapeHtml(data.description || 'N/A')}</div>
                    <div class="detail-section"><span class="detail-label">Loại tài liệu:</span> ${escapeHtml(data.materialTypeVerbose || data.materialType || 'N/A')}</div>
                    <div class="detail-section"><span class="detail-label">Chủ đề:</span> ${escapeHtml(data.categoryName || 'N/A')}</div>
                    <div class="detail-section"><span class="detail-label">Người tạo:</span> ${escapeHtml(data.creatorName || 'N/A')}</div>
                    <div class="detail-section"><span class="detail-label">Ngày tải lên:</span> ${data.uploadedAt ? new Date(data.uploadedAt).toLocaleDateString('vi-VN') : 'N/A'}</div>
                    <div class="detail-section"><span class="detail-label">Trạng thái:</span> <span class="badge status-${data.status || 'unknown'}">${escapeHtml(data.statusText || 'N/A')}</span></div>
                    <hr>
                    <div class="detail-section">
                        <span class="detail-label" style="display:block; margin-bottom:5px;">Nội dung/Preview:</span>
                        <div class="material-preview-area" id="material-preview-content">`;

                switch (data.materialType) {
                    case 'pdf':
                        contentHtml += data.filePath ? `<iframe src="${escapeAttr(data.filePath)}" width="100%" height="400px" title="PDF Preview"></iframe>` : `<p>Không có tệp PDF.</p>`;
                        break;
                    case 'docx':
                        contentHtml += data.filePath ? `<p>Tài liệu DOCX: <a href="${escapeAttr(data.filePath)}" target="_blank" title="Mở">${escapeHtml(data.fileName || 'Xem/Tải tệp')}</a></p><p><small>(Cần tải về để xem)</small></p>` : `<p>Không có tệp DOCX.</p>`;
                        break;
                    case 'video_file':
                        contentHtml += data.filePath ? `<video controls width="100%"><source src="${escapeAttr(data.filePath)}" type="video/mp4"></video>` : `<p>Không có tệp video.</p>`;
                        break;
                    case 'video_link':
                        const videoId = extractYouTubeVideoId(data.link);
                        contentHtml += videoId ? `<iframe width="100%" height="315" src="https://www.youtube.com/embed/${videoId}" title="YouTube video player" frameborder="0" allowfullscreen></iframe>` : (data.link ? `<p>Link video: <a href="${escapeAttr(data.link)}" target="_blank">${escapeHtml(data.link)}</a></p>` : `<p>Không có link video.</p>`);
                        break;
                    case 'audio_file':
                        contentHtml += data.filePath ? `<audio controls style="width:100%;"><source src="${escapeAttr(data.filePath)}" type="audio/mpeg"></audio>` : `<p>Không có tệp audio.</p>`;
                        break;
                    case 'audio_link':
                        contentHtml += data.link ? `<audio controls style="width:100%;"><source src="${escapeAttr(data.link)}" type="audio/mpeg"></audio>` : `<p>Không có link audio.</p>`;
                        break;
                    case 'external_link':
                        contentHtml += data.link ? `<p>Link ngoài: <a href="${escapeAttr(data.link)}" target="_blank">${escapeHtml(data.link)}</a> <button class="btn btn-sm btn-secondary copy-link-button" onclick="copyToClipboard('${escapeAttr(data.link)}')">Sao chép</button></p>` : `<p>Không có link.</p>`;
                        break;
                    case 'other_text':
                        contentHtml += data.textContent ? `<pre>${escapeHtml(data.textContent)}</pre>` : `<p>Không có nội dung.</p>`;
                        break;
                    default:
                        contentHtml += `<p>Không có preview.`;
                        if (data.filePath) contentHtml += ` <a href="${escapeAttr(data.filePath)}" target="_blank">${escapeHtml(data.fileName || 'Tải tệp')}</a>`;
                        else if(data.link) contentHtml += ` <a href="${escapeAttr(data.link)}" target="_blank">${escapeHtml(data.link)}</a>`;
                        contentHtml += `</p>`;
                }
                contentHtml += `</div></div>`;

                if (data.status === 'approved' && (data.filePath || data.link)) {
                     contentHtml += `<hr><div class="detail-section" style="text-align:center;">
                                        <button class="btn btn-primary action-download" onclick="downloadMaterial('${escapeAttr(data.id)}', '${escapeAttr(data.filePath || data.link || '')}', '${data.materialType && data.materialType.includes("_file") ? 'file' : 'link'}')">
                                            <svg><use xlink:href="#icon-download"></use></svg> Tải xuống tài liệu
                                        </button>
                                     </div>`;
                } else if (data.filePath || data.link) {
                     contentHtml += `<hr><div class="detail-section" style="text-align:center;"><p><small>(Tài liệu chưa được duyệt hoặc không thể tải trực tiếp)</small></p></div>`;
                }
                modalBody.innerHTML = contentHtml;
            }).catch(err => {
                console.error("Lỗi tải chi tiết tài liệu:", err);
                modalBody.innerHTML = '<p style="color:red;">Lỗi: Không thể tải thông tin chi tiết.</p>';
            });
        }
    }

    window.showDeleteMaterialConfirmModal = function(materialId) {
        const modal = document.getElementById('delete-material-confirm-modal');
        if (modal) {
            document.getElementById('material-id-to-delete').value = materialId;
            document.getElementById('delete-material-confirm-message').textContent = `Bạn chắc chắn muốn xóa tài liệu #${materialId}?`;
            openModal('delete-material-confirm-modal');
        }
    }
    window.showClassifyMaterialModal = function(materialId) {
        const modal = document.getElementById('classify-material-modal');
        if (modal) {
            document.getElementById('material-id-to-classify').value = materialId;
            document.getElementById('classify-material-modal-title').textContent = `Phân loại Tài liệu #${materialId}`;
            fetchMaterialDetails(materialId).then(data => {
                if(data){
                    document.getElementById('classify-material-category').value = data.categoryId || "";
                    document.getElementById('classify-general-material-type').value = data.generalTypeId || "";
                }
            });
            openModal('classify-material-modal');
        }
    }
    window.showReviewMaterialModal = function(materialId) {
        const modal = document.getElementById('review-material-modal');
         if (modal) {
            document.getElementById('material-id-to-review').value = materialId;
            document.getElementById('review-material-modal-title').textContent = `Xem xét Tài liệu #${materialId}`;
            const reviewPreviewContainer = document.getElementById('review-material-content-preview');
            reviewPreviewContainer.innerHTML = '<p>Đang tải preview...</p>';
            document.getElementById('review-comment').value = ''; // Clear comment

            fetchMaterialDetails(materialId).then(data => {
                if(data) {
                    document.getElementById('review-material-title-text').textContent = escapeHtml(data.title);
                    document.getElementById('review-material-description-text').textContent = escapeHtml(data.description);
                    document.getElementById('review-material-creator-text').textContent = escapeHtml(data.creatorName);
                    document.getElementById('review-material-type-text').textContent = escapeHtml(data.materialTypeVerbose || data.materialType);
                    
                    let previewHtml = ''; // Logic preview tương tự showMaterialDetailModal nhưng có thể đơn giản hơn
                    switch (data.materialType) {
                        case 'pdf': previewHtml = data.filePath ? `<p><a href="${escapeAttr(data.filePath)}" target="_blank">Xem PDF</a></p>` : 'Không có file PDF.'; break;
                        case 'video_link':
                            const videoId = extractYouTubeVideoId(data.link);
                            previewHtml = videoId ? `<iframe width="100%" height="150" src="https://www.youtube.com/embed/${videoId}" frameborder="0"></iframe>` : (data.link ? `<a href="${escapeAttr(data.link)}" target="_blank">${escapeHtml(data.link)}</a>` : 'Không có link.');
                            break;
                        // ... (thêm các case khác nếu muốn preview sâu hơn trong review modal) ...
                        default: previewHtml = (data.filePath || data.link) ? `<p><a href="${escapeAttr(data.filePath || data.link)}" target="_blank">Xem/Tải tài liệu</a></p>` : 'Không có nội dung xem trước.';
                    }
                    reviewPreviewContainer.innerHTML = previewHtml;
                } else {
                     reviewPreviewContainer.innerHTML = '<p style="color:red;">Lỗi tải preview.</p>';
                }
            }).catch(err => {
                console.error("Lỗi tải chi tiết tài liệu cho review modal:", err);
                reviewPreviewContainer.innerHTML = '<p style="color:red;">Lỗi tải preview.</p>';
            });
            openModal('review-material-modal');
        }
    }

    window.openModal = function(modalId) {
        const modal = document.getElementById(modalId);
        if (modal && modalOverlay) {
            modalOverlay.classList.remove('hidden');
            modal.classList.remove('hidden');
            if (sidebar && sidebar.classList.contains('open')) sidebar.classList.remove('open');
        }
    }
    window.closeModal = function(modalId) {
        const modal = document.getElementById(modalId);
        if (modal && modalOverlay && !modal.classList.contains('hidden')) {
            modalOverlay.classList.add('hidden');
            modal.classList.add('hidden');
        }
    }
    window.closeAllModals = function() {
        document.querySelectorAll('.modal').forEach(m => m.classList.add('hidden'));
        if (modalOverlay) modalOverlay.classList.add('hidden');
    }

    // --- Event Handlers ---
    if (materialForm) {
        materialForm.addEventListener('submit', function(event) {
            event.preventDefault();
            const materialId = materialIdInput.value;
            const formData = new FormData(materialForm);
            
            const selectedType = materialTypeFormSelect.value;
            if ((selectedType === 'pdf' || selectedType === 'docx' || selectedType === 'video_file' || selectedType === 'audio_file') && materialFileInput.required && !materialFileInput.files[0] && !currentFileLink.href.startsWith('http')) {
                alert("Vui lòng chọn một tệp tài liệu."); materialFileInput.focus(); return;
            }
            if ((selectedType === 'video_link' || selectedType === 'audio_link' || selectedType === 'external_link') && materialLinkInput.required && !materialLinkInput.value.trim()) {
                alert("Vui lòng nhập đường dẫn URL."); materialLinkInput.focus(); return;
            }
            if (selectedType === 'other_text' && materialTextContentInput.required && !materialTextContentInput.value.trim()) {
                alert("Vui lòng nhập nội dung văn bản."); materialTextContentInput.focus(); return;
            }

            console.log("--- FormData to be sent ---");
            for (let [key, value] of formData.entries()) {
                 console.log(`${key}:`, value instanceof File ? value.name : value);
            }
            console.log("---------------------------");

            if (materialId) {
                console.log("Updating material:", materialId);
                mockApiCall('PUT', `/api/materials/${materialId}`, formData).then(() => {
                    alert("Cập nhật tài liệu thành công!"); showMaterialListView();
                }).catch(err => alert(`Lỗi cập nhật: ${err.message}`));
            } else {
                console.log("Creating new material");
                 mockApiCall('POST', '/api/materials', formData).then(() => {
                    alert("Thêm tài liệu mới thành công!"); showMaterialListView();
                }).catch(err => alert(`Lỗi thêm mới: ${err.message}`));
            }
        });
    }

    const confirmDeleteMaterialBtn = document.getElementById('confirm-delete-material-button');
    if (confirmDeleteMaterialBtn) {
        confirmDeleteMaterialBtn.addEventListener('click', function() {
            const materialIdToDelete = document.getElementById('material-id-to-delete').value;
            console.log("Deleting material:", materialIdToDelete);
            mockApiCall('DELETE', `/api/materials/${materialIdToDelete}`).then(() => {
                alert(`Đã xóa tài liệu #${materialIdToDelete}`); closeModal('delete-material-confirm-modal'); loadMaterials(currentPage);
            }).catch(err => alert(`Lỗi xóa: ${err.message}`));
        });
    }

    const confirmClassifyMaterialBtn = document.getElementById('confirm-classify-material-button');
    if (confirmClassifyMaterialBtn) {
        confirmClassifyMaterialBtn.addEventListener('click', function() {
            const materialId = document.getElementById('material-id-to-classify').value;
            const categoryId = document.getElementById('classify-material-category').value;
            const generalTypeId = document.getElementById('classify-general-material-type').value;
            if(!categoryId || !generalTypeId) {
                alert("Vui lòng chọn đầy đủ thông tin phân loại."); return;
            }
            console.log("Classifying material:", materialId, { categoryId, generalTypeId });
            mockApiCall('POST', `/api/materials/${materialId}/classify`, { categoryId, generalTypeId }).then(() => {
                alert(`Đã phân loại tài liệu #${materialId}`); closeModal('classify-material-modal'); loadMaterials(currentPage);
            }).catch(err => alert(`Lỗi phân loại: ${err.message}`));
        });
    }
    
    const approveMaterialBtn = document.getElementById('approve-material-button');
    if(approveMaterialBtn) {
        approveMaterialBtn.addEventListener('click', function() {
            const materialId = document.getElementById('material-id-to-review').value;
            const comment = document.getElementById('review-comment').value;
            console.log(`Approving material #${materialId} with comment: ${comment}`);
            mockApiCall('POST', `/api/materials/${materialId}/approve`, { comment }).then(() => {
                alert(`Đã duyệt tài liệu #${materialId}`); closeModal('review-material-modal'); loadMaterials(currentPage);
            }).catch(err => alert(`Lỗi duyệt: ${err.message}`));
        });
    }

    const rejectMaterialBtn = document.getElementById('reject-material-button');
    if(rejectMaterialBtn) {
        rejectMaterialBtn.addEventListener('click', function() {
            const materialId = document.getElementById('material-id-to-review').value;
            const comment = document.getElementById('review-comment').value;
            if (!comment.trim()) {
                alert("Vui lòng nhập lý do từ chối."); return;
            }
            console.log(`Rejecting material #${materialId} with reason: ${comment}`);
            mockApiCall('POST', `/api/materials/${materialId}/reject`, { reason: comment }).then(() => {
                alert(`Đã từ chối tài liệu #${materialId}`); closeModal('review-material-modal'); loadMaterials(currentPage);
            }).catch(err => alert(`Lỗi từ chối: ${err.message}`));
        });
    }

    // --- Data Loading and Rendering ---
    function loadMaterials(page = 1, filters = {}) {
        if (!materialsTableBody) return;
        currentPage = page;
        rowsPerPage = parseInt(rowsFilterSelect.value) || 10;


        const currentFilters = {
            status: document.getElementById('status-filter').value,
            category: document.getElementById('category-filter').value,
            type: document.getElementById('type-filter').value,
            keyword: document.getElementById('keyword-search-list').value,
            ...filters
        };

        console.log("Loading materials for page:", page, "with filters:", currentFilters);
        materialsTableBody.innerHTML = `<tr><td colspan="8" style="text-align:center;">Đang tải dữ liệu...</td></tr>`;

        fetchMockMaterials(page, rowsPerPage, currentFilters)
            .then(response => {
                materialsTableBody.innerHTML = '';
                const materials = response.data;
                const totalItems = response.total;

                if (materials.length === 0) {
                    materialsTableBody.innerHTML = '<tr><td colspan="8" style="text-align:center;">Không có tài liệu nào phù hợp.</td></tr>';
                } else {
                    materials.forEach(material => {
                        const row = materialsTableBody.insertRow();
                        row.dataset.materialId = material.id;
                        
                        const materialIdEscaped = escapeAttr(material.id);
                        const filePathOrLinkEscaped = escapeAttr(material.filePath || material.link || '');
                        const materialTypeForDownload = material.materialType && material.materialType.includes("_file") ? 'file' : 'link';

                        const canDownload = material.status === 'approved' && (material.filePath || material.link);
                        const canEdit = currentUserRole === 'admin' || (currentUserRole === 'teacher' && material.creatorId === currentUserId && material.status !== 'approved');
                        const canDelete = currentUserRole === 'admin' || (currentUserRole === 'teacher' && material.creatorId === currentUserId && material.status !== 'approved');
                        const canClassify = currentUserRole === 'admin';
                        const canReview = currentUserRole === 'admin' && material.status === 'pending';

                        let actionsHtml = `
                            <button class="btn-action action-view-detail" title="Xem chi tiết" onclick="showMaterialDetailModal('${materialIdEscaped}')"><svg><use xlink:href="#icon-eye-fill"></use></svg></button>
                            <button class="btn-action action-download ${!canDownload ? 'action-hidden-placeholder' : ''}" title="${canDownload ? 'Tải xuống' : ''}" ${canDownload ? `onclick="downloadMaterial('${materialIdEscaped}', '${filePathOrLinkEscaped}', '${materialTypeForDownload}')"` : 'disabled'}><svg><use xlink:href="#icon-download"></use></svg></button>
                            <button class="btn-action action-edit ${!canEdit ? 'action-hidden-placeholder' : ''}" title="${canEdit ? 'Sửa' : ''}" ${canEdit ? `onclick="showMaterialFormView('${materialIdEscaped}')"` : 'disabled'}><svg><use xlink:href="#icon-pencil"></use></svg></button>
                            <button class="btn-action action-delete ${!canDelete ? 'action-hidden-placeholder' : ''}" title="${canDelete ? 'Xóa' : ''}" ${canDelete ? `onclick="showDeleteMaterialConfirmModal('${materialIdEscaped}')"` : 'disabled'}><svg><use xlink:href="#icon-trash"></use></svg></button>
                            <button class="btn-action action-classify ${!canClassify ? 'action-hidden-placeholder' : ''}" title="${canClassify ? 'Phân loại' : ''}" ${canClassify ? `onclick="showClassifyMaterialModal('${materialIdEscaped}')"` : 'disabled'}><svg><use xlink:href="#icon-tags"></use></svg></button>
                            <button class="btn-action action-review ${!canReview ? 'action-hidden-placeholder' : ''}" title="${canReview ? 'Duyệt/Xem xét' : ''}" ${canReview ? `onclick="showReviewMaterialModal('${materialIdEscaped}')"` : 'disabled'}><svg><use xlink:href="#icon-question-circle"></use></svg></button>
                        `;
                        
                        row.innerHTML = `
                            <td><input type="checkbox" class="row-select-material"></td>
                            <td title="${escapeHtml(material.title)}">${escapeHtml(material.title)}</td>
                            <td>${escapeHtml(material.materialTypeVerbose || 'N/A')}</td>
                            <td>${escapeHtml(material.categoryName || 'N/A')}</td>
                            <td>${escapeHtml(material.creatorName || 'N/A')}</td>
                            <td>${new Date(material.uploadedAt).toLocaleDateString('vi-VN')}</td>
                            <td><span class="badge status-${material.status || 'unknown'}">${escapeHtml(material.statusText || 'N/A')}</span></td>
                            <td class="actions">${actionsHtml}</td>
                        `;
                    });
                }
                updatePaginationControls(totalItems);
            })
            .catch(error => {
                console.error("Lỗi tải danh sách tài liệu:", error);
                materialsTableBody.innerHTML = '<tr><td colspan="8" style="text-align:center; color:red;">Lỗi tải dữ liệu. Vui lòng thử lại.</td></tr>';
                updatePaginationControls(0);
            });
    }

    function updatePaginationControls(totalItems) {
        const totalPages = Math.ceil(totalItems / rowsPerPage);
        if (paginationInfo) paginationInfo.textContent = totalItems > 0 ? `Hiển thị ${Math.min((currentPage - 1) * rowsPerPage + 1, totalItems)} - ${Math.min(currentPage * rowsPerPage, totalItems)} của ${totalItems} mục` : 'Không có mục nào';
        if (currentPageDisplay) currentPageDisplay.textContent = totalPages > 0 ? currentPage : '-';

        if (prevPageBtn) prevPageBtn.disabled = currentPage === 1 || totalItems === 0;
        if (nextPageBtn) nextPageBtn.disabled = currentPage >= totalPages || totalItems === 0;
    }

    if (prevPageBtn) prevPageBtn.addEventListener('click', () => { if (currentPage > 1) loadMaterials(currentPage - 1); });
    if (nextPageBtn) nextPageBtn.addEventListener('click', () => loadMaterials(currentPage + 1));
    if (rowsFilterSelect) rowsFilterSelect.addEventListener('change', () => { currentPage = 1; loadMaterials(currentPage); });


    window.downloadMaterial = function(materialId, path, type) {
        console.log("Requesting download for material:", materialId, "Path:", path, "Type:", type);
        if (!path) { alert("Không có đường dẫn hợp lệ để tải."); return; }
        if (type === 'link') { window.open(path, '_blank'); } 
        else {
            const link = document.createElement('a');
            link.href = path; 
            link.download = path.substring(path.lastIndexOf('/') + 1) || `material_${materialId}`; 
            document.body.appendChild(link); link.click(); document.body.removeChild(link);
            // Không có alert ở đây nữa vì có thể bị chặn
        }
    }
    
    window.copyToClipboard = function(text) {
        navigator.clipboard.writeText(text).then(() => alert('Đã sao chép link!'))
        .catch(err => alert('Lỗi sao chép: ', err));
    }
    
    function escapeHtml(unsafe) {
        if (typeof unsafe !== 'string') return '';
        return unsafe
            .replace(/&/g, "&amp;")
            .replace(/</g, "&lt;")
            .replace(/>/g, "&gt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#039;");
    }
    
    function escapeAttr(unsafe) {
        if (typeof unsafe !== 'string') return unsafe || ''; // Trả về giá trị gốc nếu không phải string, hoặc rỗng nếu null/undefined
        return unsafe
            .replace(/&/g, "&amp;")
            .replace(/</g, "&lt;")
            .replace(/>/g, "&gt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#039;")
            .replace(/`/g, "&#096;");
    }
    


    function extractYouTubeVideoId(url) {
        if(!url) return null;
        const regExp = /^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=)([^#\&\?]*).*/;
        const match = url.match(regExp);
        return (match && match[2].length === 11) ? match[2] : null;
    }

    // --- Mock API Functions ---
    let mockDatabase = [
        { id: 'TL001', title: 'Tổng hợp ngữ pháp TOEIC cơ bản (Sách)', materialType: 'pdf', materialTypeVerbose: 'PDF', generalTypeId: 'type_doc', filePath: 'https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf', fileName: 'nguphap_toeic.pdf', categoryId: 'cat3', categoryName: 'Ngữ pháp chung', creatorName: 'GV_HoaiAnh', creatorId: 'user123', uploadedAt: '2025-04-01T10:00:00Z', status: 'approved', statusText: 'Đã duyệt', tags: ['grammar', 'toeic'] },
        { id: 'TL002', title: 'Video bài giảng Part 5 TOEIC - Thầy A (File)', materialType: 'video_file', materialTypeVerbose: 'Video (File)', generalTypeId: 'type_video', filePath: 'http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4', fileName: 'part5_thay_a.mp4', categoryId: 'cat2', categoryName: 'TOEIC Reading', creatorName: 'GV_MinhTam', creatorId: 'user456', uploadedAt: '2025-03-28T14:30:00Z', status: 'pending', statusText: 'Chờ duyệt', tags: ['video', 'part 5'] },
        { id: 'TL003', title: 'Bộ đề luyện nghe Part 1 (Link Youtube)', materialType: 'video_link', materialTypeVerbose: 'Video (Link)', generalTypeId: 'type_video', link: 'https://www.youtube.com/watch?v=LXb3EKWsInQ', categoryId: 'cat1', categoryName: 'TOEIC Listening', creatorName: 'GV_HoaiAnh', creatorId: 'user123', uploadedAt: '2025-04-02T09:00:00Z', status: 'rejected', statusText: 'Bị từ chối', tags: ['listening', 'part 1', 'practice'] },
        { id: 'TL004', title: 'Tài liệu Word về Chiến thuật làm bài', materialType: 'docx', materialTypeVerbose: 'DOCX', generalTypeId: 'type_doc', filePath: '#', fileName: 'chienthuat.docx', categoryId: 'cat2', categoryName: 'TOEIC Reading', creatorName: 'GV_HoaiAnh', creatorId: 'user123', uploadedAt: '2025-04-03T11:00:00Z', status: 'approved', statusText: 'Đã duyệt', tags: ['strategy', 'reading'] },
        { id: 'TL005', title: 'Bài tập về nhà tuần 1 (Link Google Drive)', materialType: 'external_link', materialTypeVerbose: 'Link ngoài', generalTypeId: 'type_link', link: 'https://docs.google.com/document/d/1952G3_xH_3245s_sasdSADWasdadWEF_0sd', categoryId: 'cat4', categoryName: 'Từ vựng TOEIC', creatorName: 'GV_MinhTam', creatorId: 'user456', uploadedAt: '2025-04-04T15:00:00Z', status: 'pending', statusText: 'Chờ duyệt', tags: ['homework', 'vocabulary'] },
        { id: 'TL006', title: 'Ghi chú nhanh về Mạo từ (Văn bản)', materialType: 'other_text', materialTypeVerbose: 'Văn bản', generalTypeId: 'type_doc', textContent: "Mạo từ a/an/the:\n- 'a' đứng trước một danh từ đếm được số ít, bắt đầu bằng một phụ âm (trong cách phát âm).\n- 'an' đứng trước một danh từ đếm được số ít, bắt đầu bằng một nguyên âm (trong cách phát âm).\n- 'the' được dùng khi danh từ đó đã được xác định rõ ràng.", categoryId: 'cat3', categoryName: 'Ngữ pháp chung', creatorName: 'GV_HoaiAnh', creatorId: 'user123', uploadedAt: '2025-04-05T08:00:00Z', status: 'approved', statusText: 'Đã duyệt', tags: ['articles', 'grammar note'] },
        ...Array.from({length: 25}, (_, i) => ({
            id: `TL${String(i + 7).padStart(3, '0')}`, title: `Tài liệu mẫu ${i + 7} (Auto-gen)`, materialType: ['pdf', 'video_link', 'external_link'][i % 3], materialTypeVerbose: ['PDF', 'Video (Link)', 'Link ngoài'][i % 3], generalTypeId: ['type_doc', 'type_video', 'type_link'][i % 3], filePath: (i % 3 === 0) ? `https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf?id=${i+7}` : null, link: (i % 3 !== 0) ? `https://example.com/sample${i+7}` : null, fileName: (i % 3 === 0) ? `sample${i+7}.pdf` : null, categoryId: ['cat1', 'cat2', 'cat3', 'cat4'][i % 4], categoryName: ['TOEIC Listening', 'TOEIC Reading', 'Ngữ pháp chung', 'Từ vựng TOEIC'][i % 4], creatorName: (i % 2 === 0) ? 'GV_Auto_1' : 'GV_Auto_2', creatorId: `user_auto_${i % 2}`, uploadedAt: new Date(Date.now() - (i + 7) * 86400000).toISOString(), status: ['approved', 'pending', 'rejected'][i % 3], statusText: ['Đã duyệt', 'Chờ duyệt', 'Bị từ chối'][i % 3], tags: [`tag${i+1}`, `autogen`]
        }))
    ];

    function fetchMockMaterials(page = 1, limit = 10, filters = {}) {
        return new Promise(resolve => {
            let filteredData = mockDatabase.filter(m => {
                let match = true;
                if (filters.status && m.status !== filters.status) match = false;
                if (filters.category && m.categoryId !== filters.category) match = false;
                if (filters.type && m.generalTypeId !== filters.type) match = false;
                if (filters.keyword) {
                    const keywordLower = filters.keyword.toLowerCase();
                    if (!(m.title.toLowerCase().includes(keywordLower) || (m.description && m.description.toLowerCase().includes(keywordLower)) || m.creatorName.toLowerCase().includes(keywordLower))) match = false;
                }
                return match;
            });
            const total = filteredData.length;
            const startIndex = (page - 1) * limit;
            const endIndex = startIndex + limit;
            const paginatedData = filteredData.slice(startIndex, endIndex);
            setTimeout(() => resolve({ data: paginatedData, total: total, page, limit }), 300);
        });
    }

    function fetchMaterialDetails(materialId) {
         return new Promise((resolve, reject) => {
            const material = mockDatabase.find(m => m.id === materialId);
            setTimeout(() => {
                if (material) resolve(material);
                else reject(new Error("Material not found"));
            }, 100);
        });
    }

    function mockApiCall(method, url, data) {
        return new Promise((resolve, reject) => {
            console.log(`Mock API Call: ${method} ${url}`, data);
            setTimeout(() => {
                if (method === 'DELETE' && url.includes('TL000')) { reject(new Error("Không thể xóa (mock error).")); return; }
                if (method === 'POST' && data instanceof FormData && data.get('title')?.includes('error_on_create')) { reject(new Error("Lỗi server mô phỏng khi tạo.")); return; }
                
                if (method === 'POST' && url === '/api/materials' && data instanceof FormData) {
                    const newId = `TL${String(mockDatabase.length + 100 + Math.floor(Math.random()*100)).padStart(3, '0')}`;
                    const catId = data.get('categoryId');
                    const catOption = document.querySelector(`#material-category option[value="${catId}"]`);
                    const generalTypeId = data.get('generalTypeId');
                    const genTypeOption = document.querySelector(`#general-material-type-filter option[value="${generalTypeId}"]`);
                    const materialType = data.get('materialType');
                    const materialTypeOption = document.querySelector(`#material-type-form option[value="${materialType}"]`);


                    const newMaterial = {
                        id: newId, title: data.get('title'), description: data.get('description'),
                        materialType: materialType,
                        materialTypeVerbose: materialTypeOption ? materialTypeOption.textContent.split('(')[0].trim() : materialType,
                        generalTypeId: generalTypeId,
                        link: data.get('link'), textContent: data.get('textContent'),
                        filePath: data.get('file') instanceof File ? `/mock-files/uploaded_${data.get('file').name}` : null,
                        fileName: data.get('file') instanceof File ? data.get('file').name : null,
                        categoryId: catId, categoryName: catOption ? catOption.textContent : 'N/A',
                        creatorName: 'CurrentUser_Mock', creatorId: currentUserId, uploadedAt: new Date().toISOString(),
                        status: currentUserRole === 'admin' ? (data.get('statusAdmin') || 'approved') : 'pending',
                        statusText: currentUserRole === 'admin' ? (data.get('statusAdmin') === 'approved' ? 'Đã duyệt' : (data.get('statusAdmin') === 'rejected' ? 'Bị từ chối' : 'Chờ duyệt')) : 'Chờ duyệt',
                        tags: data.get('tags') ? data.get('tags').split(',').map(t => t.trim()) : []
                    };
                    mockDatabase.unshift(newMaterial);
                }
                if (method === 'PUT' && data instanceof FormData) {
                    const idToUpdate = url.substring(url.lastIndexOf('/') + 1);
                    const index = mockDatabase.findIndex(m => m.id === idToUpdate);
                    if (index > -1) {
                        mockDatabase[index].title = data.get('title') || mockDatabase[index].title;
                        mockDatabase[index].description = data.get('description') || mockDatabase[index].description;
                        mockDatabase[index].materialType = data.get('materialType') || mockDatabase[index].materialType;
                        // ... (cập nhật các trường khác tương tự)
                         if(data.get('file') instanceof File && data.get('file').name) {
                            mockDatabase[index].filePath = `/mock-files/updated_${data.get('file').name}`;
                            mockDatabase[index].fileName = data.get('file').name;
                        }
                        mockDatabase[index].link = data.get('link') !== undefined ? data.get('link') : mockDatabase[index].link; // Cho phép xóa link
                        mockDatabase[index].textContent = data.get('textContent') !== undefined ? data.get('textContent') : mockDatabase[index].textContent;


                        mockDatabase[index].status = data.get('statusAdmin') || mockDatabase[index].status;
                        mockDatabase[index].statusText = data.get('statusAdmin') === 'approved' ? 'Đã duyệt' : (data.get('statusAdmin') === 'rejected' ? 'Bị từ chối' : 'Chờ duyệt');
                    } else { reject(new Error("Không tìm thấy tài liệu để cập nhật.")); return; }
                }
                if (method === 'DELETE') {
                     const idToDelete = url.substring(url.lastIndexOf('/') + 1);
                     const initialLength = mockDatabase.length;
                     mockDatabase = mockDatabase.filter(m => m.id !== idToDelete);
                     if(mockDatabase.length === initialLength) { reject(new Error("Không tìm thấy tài liệu để xóa.")); return; }
                }
                if (method === 'POST' && url.includes('/approve')) {
                    const idToUpdate = url.split('/')[3]; const index = mockDatabase.findIndex(m => m.id === idToUpdate);
                    if (index > -1) { mockDatabase[index].status = 'approved'; mockDatabase[index].statusText = 'Đã duyệt';} else { reject(new Error("Không tìm thấy tài liệu để duyệt.")); return; }
                }
                if (method === 'POST' && url.includes('/reject')) {
                    const idToUpdate = url.split('/')[3]; const index = mockDatabase.findIndex(m => m.id === idToUpdate);
                    if (index > -1) { mockDatabase[index].status = 'rejected'; mockDatabase[index].statusText = 'Bị từ chối';} else { reject(new Error("Không tìm thấy tài liệu để từ chối.")); return; }
                }
                if (method === 'POST' && url.includes('/classify')) {
                    const idToUpdate = url.split('/')[3]; const index = mockDatabase.findIndex(m => m.id === idToUpdate);
                    if (index > -1) { 
                        mockDatabase[index].categoryId = data.categoryId;
                        mockDatabase[index].generalTypeId = data.generalTypeId;
                        // Cập nhật categoryName, generalTypeName từ select tương ứng (ví dụ)
                        const catOpt = document.querySelector(`#classify-material-category option[value="${data.categoryId}"]`);
                        const genTypeOpt = document.querySelector(`#classify-general-material-type option[value="${data.generalTypeId}"]`);
                        mockDatabase[index].categoryName = catOpt ? catOpt.textContent : 'N/A';
                        // mockDatabase[index].generalTypeName = genTypeOpt ? genTypeOpt.textContent : 'N/A'; // Nếu cần hiển thị
                    } else { reject(new Error("Không tìm thấy tài liệu để phân loại.")); return; }
                }
                resolve({ success: true, message: `${method} request to ${url} successful.` });
            }, 500);
        });
    }

    // --- Initial Load & Event Listeners for Filters ---
    showMaterialListView();
    const filterBtn = document.getElementById('apply-filters-btn');
    if (filterBtn) {
        filterBtn.addEventListener('click', () => {
            loadMaterials(1);
        });
    }
    ['status-filter', 'category-filter', 'type-filter'].forEach(filterId => {
        const select = document.getElementById(filterId);
        if(select) select.addEventListener('change', () => loadMaterials(1));
    });
     const searchInput = document.getElementById('keyword-search-list');
     if(searchInput) {
        let searchTimeout;
        searchInput.addEventListener('input', () => {
            clearTimeout(searchTimeout);
            searchTimeout = setTimeout(() => loadMaterials(1), 500);
        });
     }
});