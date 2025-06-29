document.addEventListener('DOMContentLoaded', function() {
    // --- Elements ---
    const materialListContainer = document.getElementById('student-material-list-container');
    const modalOverlay = document.getElementById('student-modal-overlay');
    const detailModal = document.getElementById('student-material-detail-modal');
    const detailModalTitle = document.getElementById('student-material-detail-modal-title');
    const detailModalBody = document.getElementById('student-material-detail-modal-body');
    const closeDetailModalBtn = document.getElementById('student-close-detail-modal-btn');
    const closeDetailModalFooterBtn = document.getElementById('student-close-detail-modal-footer-btn');

    const searchKeywordInput = document.getElementById('student-search-keyword');
    const categoryFilterSelect = document.getElementById('student-category-filter');
    const typeFilterSelect = document.getElementById('student-type-filter');
    const applyFiltersBtnV2 = document.getElementById('student-apply-filters-btn-v2');

    const paginationInfo = document.getElementById('student-pagination-info');
    const prevPageBtn = document.getElementById('student-prev-page');
    const nextPageBtn = document.getElementById('student-next-page');
    const pageNumbersContainer = document.getElementById('student-page-numbers-container');
    const mobileNavToggle = document.getElementById('mobileNavToggle');
    const siteNavStudent = document.getElementById('siteNavStudent');
    const currentFilterTitle = document.getElementById('current-filter-title');
    const materialCountInfo = document.getElementById('material-count-info');


    let currentPageStudent = 1;
    const rowsPerPageStudent = 8; // Bạn đã đổi thành 8 trong script trước
    let currentActiveFiltersStudent = { keyword: '', category: '', type: '' };

    // --- Initialize Hero Swiper ---
    const heroSwiper = new Swiper('.hero-swiper', {
        loop: true,
        autoplay: {
            delay: 4500,
            disableOnInteraction: false,
        },
        // Hiệu ứng trượt (mặc định)
        speed: 600,
        pagination: {
            el: '.hero-swiper-pagination',
            clickable: true,
        },
        navigation: {
            nextEl: '.hero-swiper-button-next',
            prevEl: '.hero-swiper-button-prev',
        },
    });


    // Mock Data với URL ảnh cụ thể hơn và chỉ tài liệu approved
    const mockFullDatabaseStudent = [
        { id: 'TL001', title: 'Tổng hợp ngữ pháp TOEIC cơ bản (Sách)', materialType: 'pdf', materialTypeVerbose: 'PDF', generalTypeId: 'type_doc', filePath: 'https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf', fileName: 'nguphap_toeic.pdf', categoryId: 'cat3', categoryName: 'Ngữ pháp chung', uploadedAt: '2025-04-01T10:00:00Z', status: 'approved', thumbnail: 'https://images.unsplash.com/photo-1507842217343-583bb7270b66?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8bGlicmFyeSUyMGJvb2tzfGVufDB8fDB8fHww&auto=format&fit=crop&w=600&q=80', tags: ['grammar', 'toeic'], description: 'Tài liệu tổng hợp các điểm ngữ pháp quan trọng thường xuất hiện trong bài thi TOEIC, giúp bạn nắm vững kiến thức nền tảng.' },
        { id: 'TL002', title: 'Video bài giảng Part 5 TOEIC - Thầy A (File)', materialType: 'video_file', materialTypeVerbose: 'Video (File)', generalTypeId: 'type_video', filePath: 'http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4', fileName: 'part5_thay_a.mp4', categoryId: 'cat2', categoryName: 'TOEIC Reading', uploadedAt: '2025-03-28T14:30:00Z', status: 'approved', thumbnail: 'https://images.unsplash.com/photo-1516280440614-3793959696B4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fHZpZGVvJTIwcGxheWVyfGVufDB8fDB8fHww&auto=format&fit=crop&w=600&q=80', tags: ['video', 'part 5'], description: 'Video hướng dẫn chi tiết cách giải quyết các câu hỏi Part 5 trong TOEIC Reading, cung cấp mẹo và chiến thuật hiệu quả.' },
        { id: 'TL003', title: 'Bộ đề luyện nghe Part 1 (Link Youtube)', materialType: 'video_link', materialTypeVerbose: 'Video (Link)', generalTypeId: 'type_video', link: 'https://www.youtube.com/watch?v=LXb3EKWsInQ', categoryId: 'cat1', categoryName: 'TOEIC Listening', uploadedAt: '2025-04-02T09:00:00Z', status: 'approved', thumbnail: 'https://img.youtube.com/vi/LXb3EKWsInQ/hqdefault.jpg', tags: ['listening', 'part 1', 'practice'], description: 'Tuyển tập các bài luyện nghe Part 1 theo format mới nhất, giúp bạn làm quen với dạng tranh và các bẫy thường gặp.' },
        { id: 'TL004', title: 'Tài liệu Word về Chiến thuật làm bài thi Đọc hiểu', materialType: 'docx', materialTypeVerbose: 'DOCX', generalTypeId: 'type_doc', filePath: '#', fileName: 'chienthuat_doc_hieu.docx', categoryId: 'cat2', categoryName: 'TOEIC Reading', uploadedAt: '2025-04-03T11:00:00Z', status: 'approved', thumbnail: 'https://images.unsplash.com/photo-1456513080510-7bf3a84b82f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fGRvY3VtZW50fGVufDB8fDB8fHww&auto=format&fit=crop&w=600&q=80', tags: ['strategy', 'reading'], description: 'Tổng hợp các chiến thuật và mẹo làm bài thi Đọc hiểu TOEIC hiệu quả, từ quản lý thời gian đến cách loại trừ đáp án sai.' },
        { id: 'TL005', title: 'Bài tập về nhà Từ vựng tuần 1 (Link Google Drive)', materialType: 'external_link', materialTypeVerbose: 'Link ngoài', generalTypeId: 'type_link', link: 'https://docs.google.com/document/d/example_vocab_week1', categoryId: 'cat4', categoryName: 'Từ vựng TOEIC', uploadedAt: '2025-04-04T15:00:00Z', status: 'approved', thumbnail: 'https://images.unsplash.com/photo-1611095969424-06935338f813?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Z29vZ2xlJTIwZHJpdmV8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=600&q=80', tags: ['homework', 'vocabulary'], description: 'Bài tập củng cố từ vựng quan trọng cho tuần học đầu tiên, bao gồm các dạng bài tập đa dạng.' },
        { id: 'TL006', title: 'Ghi chú nhanh về Mạo từ (Văn bản)', materialType: 'other_text', materialTypeVerbose: 'Văn bản', generalTypeId: 'type_doc', textContent: "Mạo từ (Articles): a, an, the.\n\n1. 'a/an' (Mạo từ không xác định):\n   - Dùng trước danh từ đếm được số ít.\n   - 'a' + phụ âm (trong cách phát âm): a book, a university.\n   - 'an' + nguyên âm (trong cách phát âm): an apple, an hour.\n   - Dùng khi nói về một đối tượng chung chung, chưa được đề cập trước đó.\n\n2. 'the' (Mạo từ xác định):\n   - Dùng khi đối tượng đã được xác định rõ ràng (người nói và người nghe đều biết).\n   - Dùng khi đối tượng đã được nhắc đến trước đó.\n   - Dùng với những thứ duy nhất (the sun, the moon).\n   - Dùng trước so sánh nhất (the best, the most important).\n   - Dùng trước tên sông, biển, đại dương, dãy núi, sa mạc, quần đảo.\n\n3. Không dùng mạo từ (Zero article):\n   - Trước danh từ không đếm được hoặc danh từ số nhiều khi nói chung chung (e.g., I like music. Cats are cute.).\n   - Trước tên riêng, tên thành phố, quốc gia (trừ một số trường hợp đặc biệt như The United States, The Philippines).\n   - Trước các bữa ăn (breakfast, lunch, dinner) khi nói chung.\n\nVí dụ: I saw a cat. The cat was black.", categoryId: 'cat3', categoryName: 'Ngữ pháp chung', uploadedAt: '2025-04-05T08:00:00Z', status: 'approved', thumbnail: 'https://images.unsplash.com/photo-1499750310107-5fef28a66643?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8bm90ZXN8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=600&q=80', tags: ['articles', 'grammar note'], description: 'Tóm tắt các quy tắc sử dụng mạo từ a/an/the trong tiếng Anh, kèm ví dụ minh họa dễ hiểu.' },
        ...Array.from({length: 25}, (_, i) => ({
            id: `TLS${String(i + 7).padStart(3, '0')}`, title: `Tài liệu TOEIC Mẫu ${i + 7}`, materialType: ['pdf', 'video_link', 'external_link', 'docx'][i % 4], materialTypeVerbose: ['PDF', 'Video (Link)', 'Link ngoài', 'DOCX'][i % 4], generalTypeId: ['type_doc', 'type_video', 'type_link', 'type_doc'][i % 4], filePath: (i % 4 === 0 || i % 4 === 3) ? `https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf?v=${i+7}` : null, link: (i % 4 === 1 || i % 4 === 2) ? `https://example.com/student-sample${i+7}` : null, fileName: (i % 4 === 0 || i % 4 === 3) ? `sample${i+7}.${['pdf','docx'][i%2]}` : null, categoryId: ['cat1', 'cat2', 'cat3', 'cat4'][i % 4], categoryName: ['TOEIC Listening', 'TOEIC Reading', 'Ngữ pháp chung', 'Từ vựng TOEIC'][i % 4], uploadedAt: new Date(Date.now() - (i + 5) * 86400000).toISOString(), status: 'approved', thumbnail: `https://picsum.photos/seed/${i+20}/600/400?grayscale&blur=1`, tags: [`toeic_sample_${i+1}`], description: `Mô tả chi tiết cho tài liệu TOEIC mẫu số ${i+7}, bao gồm các nội dung ôn luyện hữu ích.`
        }))
    ].filter(m => m.status === 'approved');


    // Mobile Nav Toggle
    if (mobileNavToggle && siteNavStudent) {
        mobileNavToggle.addEventListener('click', () => {
            siteNavStudent.classList.toggle('open');
        });
    }
    document.addEventListener('click', function(event) {
        if (siteNavStudent && siteNavStudent.classList.contains('open') &&
            !siteNavStudent.contains(event.target) &&
            !mobileNavToggle.contains(event.target)) {
            siteNavStudent.classList.remove('open');
        }
    });


    function fetchMaterialsForStudent(page = 1, limit = 8, filters = {}) { // limit đã đổi thành 8
        return new Promise(resolve => {
            let filteredData = mockFullDatabaseStudent.filter(m => {
                let match = true;
                if (filters.category && filters.category !== "" && m.categoryId !== filters.category) match = false;
                if (filters.type && filters.type !== "" && m.generalTypeId !== filters.type) match = false;
                if (filters.keyword) {
                    const keywordLower = filters.keyword.toLowerCase();
                    if (!(m.title.toLowerCase().includes(keywordLower) || (m.description && m.description.toLowerCase().includes(keywordLower)) || (m.tags && m.tags.some(tag => tag.toLowerCase().includes(keywordLower))))) {
                        match = false;
                    }
                }
                return match;
            });
            const total = filteredData.length;
            const startIndex = (page - 1) * limit;
            const endIndex = startIndex + limit;
            const paginatedData = filteredData.slice(startIndex, endIndex);
            setTimeout(() => resolve({ data: paginatedData, total, page, limit }), 200);
        });
    }

    function renderMaterialCard(material) {
        const card = document.createElement('div');
        card.className = 'material-card';
        card.dataset.materialId = material.id;

        let thumbnailHtml = `<span class="material-icon-placeholder">`;
        if (material.thumbnail) {
            thumbnailHtml = `<img src="${escapeAttr(material.thumbnail)}" alt="${escapeAttr(material.title)} Thumbnail" onerror="this.style.display='none'; this.parentElement.querySelector('.material-icon-placeholder').style.display='flex';">
                             <span class="material-icon-placeholder" style="display:none;">`;
        }
        let fallbackIconClass = 'fas fa-file-alt';
        switch (material.materialType) {
            case 'pdf': fallbackIconClass = 'fas fa-file-pdf'; break;
            case 'docx': fallbackIconClass = 'fas fa-file-word'; break;
            case 'video_file': case 'video_link': fallbackIconClass = 'fas fa-video'; break;
            case 'audio_file': case 'audio_link': fallbackIconClass = 'fas fa-volume-up'; break;
            case 'external_link': fallbackIconClass = 'fas fa-external-link-alt'; break;
        }
        thumbnailHtml += `<i class="${fallbackIconClass}"></i></span>`;
        
        const canDownloadStudent = material.status === 'approved' && (material.filePath || material.link);

        card.innerHTML = `
            <div class="material-thumbnail">${thumbnailHtml}</div>
            <div class="material-info">
                <h3 class="material-title" title="${escapeHtml(material.title)}">${escapeHtml(material.title)}</h3>
                <p class="material-category"><i class="fas fa-folder"></i> ${escapeHtml(material.categoryName || 'Chưa phân loại')}</p>
                <p class="material-type-display"><i class="fas fa-tag"></i> Loại: ${escapeHtml(material.materialTypeVerbose || 'N/A')}</p>
            </div>
            <div class="material-actions-student">
                <button class="btn btn-primary-v2 btn-sm view-material-detail-btn">Xem chi tiết</button>
                ${canDownloadStudent ? `<button class="btn btn-outline-success-v2 btn-sm download-material-btn"> <i class="fas fa-download"></i> Tải về</button>` : ''}
            </div>
        `;
        // Gán event listener sau khi innerHTML
        const viewDetailButton = card.querySelector('.view-material-detail-btn');
        if (viewDetailButton) {
             viewDetailButton.addEventListener('click', () => showStudentMaterialDetailModal(material.id));
        }
       
        if (canDownloadStudent) {
            const downloadButton = card.querySelector('.download-material-btn');
            if (downloadButton) {
                downloadButton.addEventListener('click', () => downloadStudentMaterial(material.id, material.filePath || material.link, material.materialType));
            }
        }
        return card;
    }

    function loadMaterialsForStudentDisplay(page = 1, updatePageTitle = true) {
        currentPageStudent = page;
        currentActiveFiltersStudent = {
            keyword: searchKeywordInput.value.trim(),
            category: categoryFilterSelect.value,
            type: typeFilterSelect.value
        };
        
        if (!materialListContainer) return;
        
        if (page === 1 && updatePageTitle) {
            materialListContainer.innerHTML = Array(rowsPerPageStudent).fill(0).map(() => renderLoadingPlaceholderCard()).join('');
        } else if (materialListContainer.children.length === 0 || materialListContainer.querySelector('.loading-spinner-container')) {
             materialListContainer.innerHTML = `<div class="loading-spinner-container" style="grid-column: 1 / -1; text-align: center; padding: 40px 0;"><div class="loading-spinner"></div><p>Đang tải tài liệu...</p></div>`;
        }

        if (updatePageTitle && currentFilterTitle) {
            let titleText = "Tất cả Tài liệu";
            if(currentActiveFiltersStudent.category && currentActiveFiltersStudent.category !== "") {
                const catOption = categoryFilterSelect.querySelector(`option[value="${currentActiveFiltersStudent.category}"]`);
                if (catOption) titleText = catOption.textContent;
            } else if (currentActiveFiltersStudent.type && currentActiveFiltersStudent.type !== "") {
                 const typeOption = typeFilterSelect.querySelector(`option[value="${currentActiveFiltersStudent.type}"]`);
                if (typeOption) titleText = typeOption.textContent;
            }
            currentFilterTitle.textContent = titleText;
        }

        fetchMaterialsForStudent(page, rowsPerPageStudent, currentActiveFiltersStudent)
            .then(response => {
                materialListContainer.innerHTML = '';
                if (response.data.length === 0) {
                    materialListContainer.innerHTML = '<p style="text-align:center; grid-column: 1 / -1; padding: 30px 0; font-size: 1.1em; color: var(--text-color-light);">Không tìm thấy tài liệu nào phù hợp với lựa chọn của bạn.</p>';
                } else {
                    response.data.forEach(material => {
                        materialListContainer.appendChild(renderMaterialCard(material));
                    });
                }
                if(materialCountInfo) materialCountInfo.textContent = `(${response.total} kết quả)`;
                updateStudentPaginationControls(response.total);
            })
            .catch(error => {
                console.error("Lỗi tải tài liệu cho học sinh:", error);
                materialListContainer.innerHTML = '<p style="text-align:center; color:red; grid-column: 1 / -1;">Không thể tải tài liệu. Vui lòng thử lại sau.</p>';
                if(materialCountInfo) materialCountInfo.textContent = '(0 kết quả)';
                updateStudentPaginationControls(0);
            });
    }

    function renderLoadingPlaceholderCard() {
        return `
            <div class="material-card is-loading-placeholder">
                <div class="material-thumbnail"><div class="thumbnail-placeholder-shape"></div></div>
                <div class="material-info">
                    <h3 class="material-title placeholder-text" style="height: 2.7em; width: 80%; background-color: #e0e0e0; margin-bottom: 12px;"></h3>
                    <p class="material-category placeholder-text" style="width: 60%; background-color: #e9e9e9; height: 0.8em; margin-bottom: 8px;"></p>
                    <p class="material-type-display placeholder-text" style="width: 45%; background-color: #e9e9e9; height: 0.8em;"></p>
                </div>
                <div class="material-actions-student">
                    <button class="btn btn-primary-v2 btn-sm placeholder-button" style="width: 110px; background-color: #e0e0e0; border-color: #e0e0e0;"></button>
                    <button class="btn btn-outline-success-v2 btn-sm placeholder-button" style="width: 90px; background-color: #e0e0e0; border-color: #e0e0e0;"></button>
                </div>
            </div>
        `;
    }
    
    function updateStudentPaginationControls(totalItems) {
        const totalPages = Math.ceil(totalItems / rowsPerPageStudent);
        if (paginationInfo) paginationInfo.textContent = totalItems > 0 ? `Trang ${currentPageStudent} / ${totalPages}` : 'Không có tài liệu';
        
        if (pageNumbersContainer) {
            pageNumbersContainer.innerHTML = '';
            if (totalPages > 1) {
                let startPage = Math.max(1, currentPageStudent - 2);
                let endPage = Math.min(totalPages, currentPageStudent + 2);

                if (currentPageStudent <= 3) endPage = Math.min(totalPages, 5);
                if (currentPageStudent > totalPages - 3) startPage = Math.max(1, totalPages - 4);

                if (startPage > 1) {
                    pageNumbersContainer.appendChild(createPageNumberButton(1));
                    if (startPage > 2) pageNumbersContainer.appendChild(createPageEllipsis());
                }
                for (let i = startPage; i <= endPage; i++) {
                    pageNumbersContainer.appendChild(createPageNumberButton(i));
                }
                if (endPage < totalPages) {
                    if (endPage < totalPages - 1) pageNumbersContainer.appendChild(createPageEllipsis());
                    pageNumbersContainer.appendChild(createPageNumberButton(totalPages));
                }
            }
        }

        if (prevPageBtn) prevPageBtn.disabled = currentPageStudent === 1 || totalItems === 0;
        if (nextPageBtn) nextPageBtn.disabled = currentPageStudent >= totalPages || totalItems === 0;
    }

    function createPageNumberButton(pageNumber) {
        const button = document.createElement('button');
        button.classList.add('page-number');
        if (pageNumber === currentPageStudent) {
            button.classList.add('active');
        }
        button.textContent = pageNumber;
        button.addEventListener('click', () => loadMaterialsForStudentDisplay(pageNumber, false));
        return button;
    }
    function createPageEllipsis() {
        const span = document.createElement('span');
        span.classList.add('page-ellipsis');
        span.textContent = '...';
        return span;
    }

    // === HÀM QUẢN LÝ MODAL CHUNG ===
    function openModal(modalId) { // Đổi tên hàm này cho nhất quán
        const modalToOpen = document.getElementById(modalId); // Đổi tên biến local
        const currentModalOverlay = document.getElementById('student-modal-overlay'); 

        if (modalToOpen && currentModalOverlay) {
            currentModalOverlay.classList.remove('hidden');
            modalToOpen.classList.remove('hidden');
            if (siteNavStudent && siteNavStudent.classList.contains('open')) { // Đóng mobile nav nếu mở
                siteNavStudent.classList.remove('open');
            }
        } else {
            console.error(`Modal with ID "${modalId}" or modal overlay not found for openModal.`);
        }
    }

    function closeModal(modalId) {
        const modalToClose = document.getElementById(modalId); // Đổi tên biến local
        const currentModalOverlay = document.getElementById('student-modal-overlay');
        
        if (modalToClose && currentModalOverlay && !modalToClose.classList.contains('hidden')) {
            currentModalOverlay.classList.add('hidden');
            modalToClose.classList.add('hidden');

            if (modalId === 'student-material-detail-modal') {
                const currentDetailModalBody = document.getElementById('student-material-detail-modal-body'); // Lấy lại body
                if (currentDetailModalBody) {
                    const videoPlayer = currentDetailModalBody.querySelector('video');
                    const audioPlayer = currentDetailModalBody.querySelector('audio');
                    const youtubeIframe = currentDetailModalBody.querySelector('iframe[src*="youtube.com"]');
                    if (videoPlayer) videoPlayer.pause();
                    if (audioPlayer) audioPlayer.pause();
                    if (youtubeIframe && youtubeIframe.contentWindow) {
                        try { 
                           youtubeIframe.contentWindow.postMessage('{"event":"command","func":"pauseVideo","args":""}', '*');
                        } catch (e) {
                           console.warn("Could not pause YouTube video in iframe:", e);
                        }
                    }
                    currentDetailModalBody.innerHTML = '<p>Đang tải chi tiết...</p>';
                }
            }
        }
    }

    function closeAllModals() { // Sửa lại để dùng closeModal đã định nghĩa
        document.querySelectorAll('.modal').forEach(m => {
            if (!m.classList.contains('hidden')) { // Chỉ đóng nếu đang mở
                closeModal(m.id);
            }
        });
    }


    function showStudentMaterialDetailModal(materialId) {
        // Lấy lại các element này bên trong hàm để chắc chắn chúng tồn tại và đúng scope
        const currentDetailModal = document.getElementById('student-material-detail-modal');
        const currentModalBody = document.getElementById('student-material-detail-modal-body');
        const currentModalTitle = document.getElementById('student-material-detail-modal-title');

        if (!currentDetailModal || !currentModalBody || !currentModalTitle) {
            console.error("student-material-detail-modal or its components not found when trying to show.");
            return;
        }
        currentModalTitle.textContent = `Chi tiết Tài liệu`; 
        currentModalBody.innerHTML = '<div class="loading-spinner-container" style="padding: 40px 0; text-align:center;"><div class="loading-spinner"></div><p>Đang tải chi tiết...</p></div>';
        
        openModal('student-material-detail-modal'); // Gọi hàm openModal đã được định nghĩa ở trên

        const materialData = mockFullDatabaseStudent.find(m => m.id === materialId); 

        if (!materialData) {
            currentModalBody.innerHTML = '<p style="color:red;">Không tìm thấy thông tin tài liệu.</p>';
            return;
        }
        
        setTimeout(() => {
            currentModalTitle.textContent = escapeHtml(materialData.title);
            let contentHtml = `
                ${materialData.thumbnail ? `<div style="text-align:center; margin-bottom:20px;"><img src="${escapeAttr(materialData.thumbnail)}" alt="Thumbnail" style="max-width:100%; max-height:300px; border-radius:var(--border-radius-base); object-fit:contain; box-shadow: var(--box-shadow-light);"></div>` : ''}
                <div class="detail-section"><span class="detail-label">Tiêu đề:</span> ${escapeHtml(materialData.title || 'N/A')}</div>
                <div class="detail-section"><span class="detail-label">Mô tả:</span> <div style="margin-top: 5px; line-height: 1.7;">${escapeHtml(materialData.description || 'N/A').replace(/\n/g, '<br>')}</div></div>
                <div class="detail-section"><span class="detail-label">Loại tài liệu:</span> ${escapeHtml(materialData.materialTypeVerbose || materialData.materialType || 'N/A')}</div>
                <div class="detail-section"><span class="detail-label">Chủ đề:</span> ${escapeHtml(materialData.categoryName || 'N/A')}</div>
                <div class="detail-section"><span class="detail-label">Ngày đăng:</span> ${materialData.uploadedAt ? new Date(materialData.uploadedAt).toLocaleDateString('vi-VN') : 'N/A'}</div>
                <hr style="margin: 20px 0;">
                <div class="detail-section">
                    <span class="detail-label" style="display:block; margin-bottom:10px; font-size: 1.1em;">Nội dung / Preview:</span>
                    <div class="material-preview-area" id="student-material-preview-content">`;

            switch (materialData.materialType) {
                case 'pdf': contentHtml += materialData.filePath ? `<iframe src="${escapeAttr(materialData.filePath)}" width="100%" height="500px" style="border:none; border-radius:var(--border-radius-base);"></iframe>` : `<p>Không có file PDF.</p>`; break;
                case 'docx': contentHtml += materialData.filePath ? `<p>Tài liệu DOCX: <a href="${escapeAttr(materialData.filePath)}" target="_blank" class="btn btn-sm btn-outline-success-v2"><i class="fas fa-file-word"></i> ${escapeHtml(materialData.fileName || 'Xem/Tải')}</a></p><p><small>(Cần tải về để xem nội dung đầy đủ)</small></p>` : `<p>Không có file DOCX.</p>`; break;
                case 'video_file': contentHtml += materialData.filePath ? `<video controls width="100%" style="border-radius:var(--border-radius-base);"><source src="${escapeAttr(materialData.filePath)}" type="video/mp4"></video>` : `<p>Không có file video.</p>`; break;
                case 'video_link':
                    const videoId = extractYouTubeVideoId(materialData.link);
                    contentHtml += videoId ? `<div style="position: relative; padding-bottom: 56.25%; height: 0; overflow: hidden; max-width: 100%; background: #000; border-radius:var(--border-radius-base);"><iframe style="position: absolute; top: 0; left: 0; width: 100%; height: 100%;" src="https://www.youtube.com/embed/${videoId}" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe></div>` : (materialData.link ? `<p><a href="${escapeAttr(materialData.link)}" target="_blank" class="btn btn-sm btn-primary-v2"><i class="fas fa-external-link-alt"></i> Đi đến Video</a></p>` : `<p>Không có link video.</p>`);
                    break;
                case 'audio_file': contentHtml += materialData.filePath ? `<audio controls style="width:100%;"><source src="${escapeAttr(materialData.filePath)}" type="audio/mpeg"></audio>` : `<p>Không có file audio.</p>`; break;
                case 'audio_link': contentHtml += materialData.link ? `<audio controls style="width:100%;"><source src="${escapeAttr(materialData.link)}" type="audio/mpeg"></audio>` : `<p>Không có link audio.</p>`; break;
                case 'external_link': contentHtml += materialData.link ? `<p><a href="${escapeAttr(materialData.link)}" target="_blank" class="btn btn-sm btn-primary-v2"><i class="fas fa-external-link-alt"></i> Mở Link</a> <button class="btn btn-sm btn-secondary-v2 copy-link-button" onclick="copyToClipboard('${escapeAttr(materialData.link)}')"><i class="fas fa-copy"></i> Sao chép</button></p>` : `<p>Không có link.</p>`; break;
                case 'other_text': contentHtml += materialData.textContent ? `<pre>${escapeHtml(materialData.textContent)}</pre>` : `<p>Không có nội dung.</p>`; break;
                default: contentHtml += `<p>Không có preview.`;
                    if (materialData.filePath) contentHtml += ` <a href="${escapeAttr(materialData.filePath)}" target="_blank" class="btn btn-sm btn-outline-success-v2"><i class="fas fa-download"></i> ${escapeHtml(materialData.fileName || 'Tải tệp')}</a>`;
                    else if(materialData.link) contentHtml += ` <a href="${escapeAttr(materialData.link)}" target="_blank" class="btn btn-sm btn-primary-v2"><i class="fas fa-link"></i> Mở Link</a>`;
                    contentHtml += `</p>`;
            }
            contentHtml += `</div></div>`;

            if (materialData.status === 'approved' && (materialData.filePath || materialData.link)) {
                 contentHtml += `<hr style="margin: 25px 0;"><div class="detail-section" style="text-align:center; margin-top: 20px;">
                                    <button class="btn btn-primary-v2 action-download" onclick="downloadStudentMaterial('${escapeAttr(materialData.id)}', '${escapeAttr(materialData.filePath || materialData.link || '')}', '${materialData.materialType && materialData.materialType.includes("_file") ? 'file' : 'link'}')">
                                        <i class="fas fa-download"></i> Tải xuống tài liệu
                                    </button>
                                 </div>`;
            }
            currentModalBody.innerHTML = contentHtml;
        }, 300);
    }

    // Event Listeners for Modal Close (sử dụng hàm closeModal đã định nghĩa)
    if (closeDetailModalBtn) closeDetailModalBtn.addEventListener('click', () => closeModal('student-material-detail-modal'));
    if (closeDetailModalFooterBtn) closeDetailModalFooterBtn.addEventListener('click', () => closeModal('student-material-detail-modal'));
    if (modalOverlay) modalOverlay.addEventListener('click', (e) => { 
        if(e.target === modalOverlay) closeModal('student-material-detail-modal'); 
    });


    window.downloadStudentMaterial = function(materialId, path, type) {
        console.log("Student downloading:", materialId, path, type);
        if (!path || path === '#') { alert("Tài liệu này hiện không có sẵn để tải xuống."); return; }
        if (type === 'link' || path.startsWith('http')) { 
            window.open(path, '_blank');
        } else { 
            const link = document.createElement('a');
            link.href = path; 
            link.download = path.substring(path.lastIndexOf('/') + 1) || `tai_lieu_${materialId}`; 
            document.body.appendChild(link); link.click(); document.body.removeChild(link);
        }
    }
    
    window.copyToClipboard = function(text) {
        navigator.clipboard.writeText(text).then(() => alert('Đã sao chép link!'))
        .catch(err => { console.error('Lỗi sao chép: ', err); alert('Không thể sao chép link.');});
    }
    
    function escapeHtml(unsafe) { /* Giữ nguyên */
    if (typeof unsafe !== 'string') return '';
    return unsafe
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;");
}

function escapeAttr(unsafe) { /* Giữ nguyên */
    if (typeof unsafe !== 'string') return unsafe || '';
    return unsafe
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;")
        .replace(/`/g, "&#x60;");
}

    function extractYouTubeVideoId(url) {
        if(!url) return null;
        const regExp = /^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=)([^#\&\?]*).*/;
        const match = url.match(regExp);
        return (match && match[2].length === 11) ? match[2] : null;
    }

    // --- Event Listeners ---
    if (applyFiltersBtnV2) {
        applyFiltersBtnV2.addEventListener('click', () => loadMaterialsForStudentDisplay(1, true));
    }
    [categoryFilterSelect, typeFilterSelect].forEach(select => {
        if (select) select.addEventListener('change', () => loadMaterialsForStudentDisplay(1, true));
    });
    if (searchKeywordInput) {
        let searchTimeoutStudent;
        searchKeywordInput.addEventListener('input', () => {
            clearTimeout(searchTimeoutStudent);
            searchTimeoutStudent = setTimeout(() => loadMaterialsForStudentDisplay(1, true), 500);
        });
         searchKeywordInput.addEventListener('keypress', function(e) {
            if (e.key === 'Enter') {
                clearTimeout(searchTimeoutStudent);
                loadMaterialsForStudentDisplay(1, true);
            }
        });
    }

    if (prevPageBtn) prevPageBtn.addEventListener('click', () => { if (currentPageStudent > 1) loadMaterialsForStudentDisplay(currentPageStudent - 1, false); });
    if (nextPageBtn) nextPageBtn.addEventListener('click', () => { 
         fetchMaterialsForStudent(currentPageStudent, rowsPerPageStudent, currentActiveFiltersStudent).then(res => {
            const totalPages = Math.ceil(res.total / rowsPerPageStudent);
            if (currentPageStudent < totalPages) loadMaterialsForStudentDisplay(currentPageStudent + 1, false);
        });
    });

    // Initial load
    loadMaterialsForStudentDisplay(1, true);

    // --- Scroll to Top Button Logic ---
    const scrollToTopBtn = document.getElementById("scrollToTopBtn");

    if (scrollToTopBtn) {
        window.onscroll = function() {
            if (document.body.scrollTop > 100 || document.documentElement.scrollTop > 100) {
                scrollToTopBtn.style.display = "block";
                // Trigger reflow to apply opacity transition
                setTimeout(() => { scrollToTopBtn.style.opacity = "1"; }, 10); 
            } else {
                scrollToTopBtn.style.opacity = "0";
                setTimeout(() => {
                    if (!(document.body.scrollTop > 100 || document.documentElement.scrollTop > 100)) {
                         scrollToTopBtn.style.display = "none";
                    }
                }, 300); // Match CSS transition duration
            }
        };

        scrollToTopBtn.addEventListener("click", function(e) {
            e.preventDefault();
            window.scrollTo({top: 0, behavior: 'smooth'});
        });
    }
});