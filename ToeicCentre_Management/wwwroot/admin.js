// IIFE (Immediately Invoked Function Expression) để tạo một scope riêng.
(function () {
    // Chạy code chính khi DOM đã sẵn sàng
    document.addEventListener('DOMContentLoaded', function () {
        initializeGlobalComponents();
        if (document.getElementById('question-bank-content')) {
            initializeQuestionBankPage();
        }
    });

    // =================================================================
    // CÁC HÀM KHỞI TẠO (INITIALIZERS)
    // =================================================================

    function initializeGlobalComponents() {
        const sidebar = document.getElementById('sidebar');
        const sidebarToggle = document.getElementById('sidebar-toggle');
        const sidebarOpenMobile = document.getElementById('sidebar-open-mobile');
        const sidebarCloseMobile = document.getElementById('sidebar-close-mobile');
        const modalOverlay = document.getElementById('modal-overlay');

        if (sidebarToggle && sidebar) {
            sidebarToggle.addEventListener('click', () => {
                sidebar.classList.toggle('collapsed');
                localStorage.setItem('sidebarCollapsed', sidebar.classList.contains('collapsed'));
            });
            if (window.innerWidth > 768 && localStorage.getItem('sidebarCollapsed') === 'true') {
                sidebar.classList.add('collapsed');
            }
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
    }

    function initializeQuestionBankPage() {
        const questionForm = document.getElementById('question-form');
        const partSelect = document.getElementById('part-select');

        if (partSelect) {
            partSelect.addEventListener('change', updateFormFields);
        }
        if (questionForm) {
            questionForm.addEventListener('submit', (e) => e.preventDefault());
        }
    }

    // =================================================================
    // CÁC HÀM XỬ LÝ SỰ KIỆN (EVENT HANDLERS)
    // =================================================================

    function handleDeleteConfirmation() {
        const questionIdToDelete = document.getElementById('question-id-to-delete').value;
        if (!questionIdToDelete) return;

        fetch(`/api/questions/${questionIdToDelete}`, {
            method: 'DELETE'
        })
            .then(async response => {
                if (response.ok) {
                    const row = document.querySelector(`tbody tr[data-question-id="${questionIdToDelete}"]`);
                    if (row) row.remove();
                    alert('Xóa câu hỏi thành công!');
                    closeModal('delete-confirm-modal');
                } else {
                    const errorText = await response.text();
                    alert(`Lỗi: ${errorText}`);
                }
            })
            .catch(error => console.error('Lỗi khi xóa:', error));
    }

    function handleClassificationSave() {
        const questionId = document.getElementById('question-id-to-classify').value;
        const partId = document.getElementById('classify-part').value;
        const difficultyId = document.getElementById('classify-difficulty').value;

        if (!questionId || !partId || !difficultyId) {
            alert("Vui lòng chọn đầy đủ thông tin phân loại."); return;
        }

        const dataToSend = { questionId: parseInt(questionId), partId: parseInt(partId), difficultyId: parseInt(difficultyId) };

        fetch('/api/questions/classify', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(dataToSend)
        })
            .then(response => response.json().then(data => ({ ok: response.ok, data })))
            .then(({ ok, data }) => {
                if (ok) {
                    alert(data.message || 'Cập nhật thành công!');
                    closeModal('classify-modal');
                    window.location.reload();
                } else {
                    throw new Error(data.message || 'Lỗi không xác định từ server');
                }
            })
            .catch(error => alert(`Có lỗi xảy ra khi lưu phân loại: ${error.message}`));
    }

    function handleApprovalAction(questionId, newStatus) {
        const commentInput = document.getElementById('review-comment');
        const comment = commentInput ? commentInput.value : "";

        if (newStatus !== "Đã duyệt" && !comment.trim()) {
            alert("Vui lòng nhập ghi chú/lý do để Yêu cầu sửa hoặc Từ chối.");
            commentInput.focus();
            return;
        }

        const dataToSend = { questionId, newStatus, comment };

        fetch('/api/questions/approve', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(dataToSend)
        })
            .then(response => response.json().then(data => ({ ok: response.ok, data })))
            .then(({ ok, data }) => {
                if (ok) {
                    alert(data.message);
                    closeModal('approval-modal');
                    updateTableRowStatus(questionId, data.newStatusName);
                } else {
                    throw new Error(data.message || 'Lỗi không xác định');
                }
            })
            .catch(error => alert(`Lỗi: ${error.message}`));
    }

    // =================================================================
    // CÁC HÀM QUẢN LÝ GIAO DIỆN
    // =================================================================

    window.showModal = function (modalId) {
        const modal = document.getElementById(modalId);
        const modalOverlay = document.getElementById('modal-overlay');
        if (modal && modalOverlay) {
            modal.classList.remove('hidden');
            modalOverlay.classList.remove('hidden');
        }
    };

    window.closeModal = function (modalId) {
        const modal = document.getElementById(modalId);
        if (modal) modal.classList.add('hidden');
        if (document.querySelectorAll('.modal:not(.hidden)').length === 0) {
            const modalOverlay = document.getElementById('modal-overlay');
            if (modalOverlay) modalOverlay.classList.add('hidden');
        }
    };

    window.closeAllModals = function () {
        document.querySelectorAll('.modal').forEach(m => m.classList.add('hidden'));
        const modalOverlay = document.getElementById('modal-overlay');
        if (modalOverlay) modalOverlay.classList.add('hidden');
    };

    window.showDeleteConfirmModal = function (questionId) {
        const modalId = 'delete-confirm-modal';
        const confirmBtn = document.getElementById('confirm-delete-button');
        document.getElementById('question-id-to-delete').value = questionId;
        document.getElementById('delete-confirm-message').textContent = `Bạn chắc chắn muốn xóa câu hỏi #${questionId}?`;

        const newConfirmBtn = confirmBtn.cloneNode(true);
        confirmBtn.parentNode.replaceChild(newConfirmBtn, confirmBtn);
        newConfirmBtn.addEventListener('click', handleDeleteConfirmation);

        showModal(modalId);
    };

    window.showDetailModal = function (questionId) {
        const modalId = 'detail-modal';
        const title = document.getElementById('detail-modal-title');
        const body = document.getElementById('detail-modal-body-content');

        if (!title || !body) return;

        title.innerText = `Chi tiết Câu hỏi #${questionId}`;
        body.innerHTML = '<p>Đang tải chi tiết...</p>';
        showModal(modalId);

        fetchQuestionDetails(questionId).then(data => {
            let detailHtml = `
                <p><strong>ID:</strong> ${data.id || 'N/A'}</p>
                <p><strong>Phần thi:</strong> ${data.partName || 'Chưa phân loại'}</p>
                <p><strong>Kỹ năng:</strong> ${data.skillName || 'Chưa phân loại'}</p>
                <p><strong>Độ khó:</strong> ${data.difficultyName || 'Chưa phân loại'}</p>
                <p><strong>Trạng thái:</strong> <span class="badge status-${(data.statusName || "").toLowerCase().replace(' ', '-')}">${data.statusName || 'N/A'}</span></p>
                <p><strong>Người tạo:</strong> ${data.creatorName || 'N/A'}</p>
                <p><strong>Ngày tạo:</strong> ${data.createdAt ? new Date(data.createdAt).toLocaleDateString('vi-VN') : 'N/A'}</p>
                <hr>
                ${data.imagePath ? `<p><strong>Hình ảnh:</strong><br><img src="/${data.imagePath}" style="max-width: 100%; border-radius: 4px;"></p><hr>` : ''}
                ${data.audioPath ? `<p><strong>Audio riêng:</strong> <audio controls src="/${data.audioPath}" class="w-100"></audio></p><hr>` : ''}
                ${data.questionText ? `<p><strong>Nội dung câu hỏi:</strong></p><div style="white-space: pre-wrap; background: #f8f9fa; padding: 10px; border-radius: 4px;">${data.questionText}</div><hr>` : ''}
                ${data.answers && data.answers.length > 0 ? `<p><strong>Các lựa chọn đáp án:</strong></p><ul> ${data.answers.map(ans => `<li><strong>${ans.displayOrder || '?'}:</strong> ${ans.text} ${ans.isCorrect ? '<span class="correct-answer">✅</span>' : ''}</li>`).join('')} </ul><hr>` : ''}
                ${data.explanation ? `<p><strong>Giải thích:</strong></p><div style="white-space: pre-wrap;">${data.explanation}</div>` : ''}`;
            body.innerHTML = detailHtml;
        }).catch(err => {
            body.innerHTML = `<p class="text-danger">Lỗi tải dữ liệu: ${err.message}</p>`;
        });
    };

    window.showApprovalModal = function (questionId) {
        const modalId = 'approval-modal';
        const title = document.getElementById('approval-modal-title');
        const body = document.getElementById('approval-modal-body');
        const footer = document.getElementById('approval-modal-footer');

        if (!title || !body || !footer) return;

        title.innerText = `Xem xét Câu hỏi #${questionId}`;
        body.innerHTML = '<p>Đang tải...</p>';
        showModal(modalId);

        fetchQuestionDetails(questionId).then(data => {
            body.innerHTML = `
                <p><strong>Phần thi:</strong> ${data.partName || 'N/A'}</p>
                <p><strong>Người tạo:</strong> ${data.creatorName || 'N/A'}</p>
                <hr>
                ${data.imagePath ? `<p><strong>Hình ảnh:</strong><br><img src="/${data.imagePath}" alt="Ảnh câu hỏi" style="max-width:100%;"></p><hr>` : ''}
                ${data.audioPath ? `<p><strong>Audio:</strong><br><audio controls src="/${data.audioPath}" class="w-100"></audio></p><hr>` : ''}
                <p><strong>Nội dung:</strong></p><div style="white-space: pre-wrap; background: #f8f9fa; padding: 10px; border-radius: 4px;">${data.questionText || 'Không có'}</div><hr>
                <p><strong>Đáp án:</strong></p>
                <ul>${data.answers ? data.answers.map(a => `<li><strong>${a.displayOrder}:</strong> ${a.text} ${a.isCorrect ? '✅' : ''}</li>`).join('') : ''}</ul><hr>
                <p><strong>Giải thích:</strong></p><div style="white-space: pre-wrap;">${data.explanation || 'Không có'}</div><hr>
                <div class="form-group">
                    <label for="review-comment">Ghi chú / Lý do:</label>
                    <textarea id="review-comment" rows="3" class="form-control"></textarea>
                </div>`;

            footer.querySelector('.btn-success').onclick = () => handleApprovalAction(questionId, 'Đã duyệt');
            footer.querySelector('.btn-warning').onclick = () => handleApprovalAction(questionId, 'Cần chỉnh sửa');
            footer.querySelector('.btn-danger').onclick = () => handleApprovalAction(questionId, 'Từ chối');

        }).catch(err => {
            body.innerHTML = `<p class="text-danger">Lỗi tải dữ liệu: ${err.message}</p>`;
        });
    };

    window.showClassifyModal = function (questionId) {
        const modalId = 'classify-modal';
        const title = document.getElementById('classify-modal-title');
        const idInput = document.getElementById('question-id-to-classify');
        const confirmBtn = document.getElementById('confirm-classify-button');

        if (title && idInput && confirmBtn) {
            title.innerText = `Phân loại Câu hỏi #${questionId}`;
            idInput.value = questionId;
            showModal(modalId);

            fetchCurrentClassification(questionId).then(currentData => {
                document.getElementById('classify-skill').value = currentData.skillId || "";
                document.getElementById('classify-part').value = currentData.partId || "";
                document.getElementById('classify-difficulty').value = currentData.difficultyId || "";
            });

            const newConfirmBtn = confirmBtn.cloneNode(true);
            confirmBtn.parentNode.replaceChild(newConfirmBtn, confirmBtn);
            newConfirmBtn.addEventListener('click', handleClassificationSave);
        }
    };

    function updateFormFields() {
        const partSelect = document.getElementById('part-select');
        if (!partSelect) return;
        const partValue = partSelect.value;
        const groupSection = document.getElementById('group-section');
        const imageSection = document.getElementById('image-section');
        const audioSection = document.getElementById('audio-section');
        const answerDOption = document.getElementById('answer-d-option');
        const questionContentSection = document.getElementById('question-content-section');

        if (groupSection) groupSection.style.display = 'none';
        if (imageSection) imageSection.style.display = 'none';
        if (audioSection) audioSection.style.display = 'none';
        if (questionContentSection) questionContentSection.style.display = 'block';
        if (answerDOption) answerDOption.style.display = 'flex';

        switch (String(partValue)) {
            case '1':
                if (imageSection) imageSection.style.display = 'block';
                if (audioSection) audioSection.style.display = 'block';
                if (questionContentSection) questionContentSection.style.display = 'none';
                break;
            case '2':
                if (audioSection) audioSection.style.display = 'block';
                if (questionContentSection) questionContentSection.style.display = 'none';
                if (answerDOption) answerDOption.style.display = 'none';
                break;
            case '3':
            case '4':
                if (groupSection) groupSection.style.display = 'block';
                if (audioSection) audioSection.style.display = 'block';
                break;
            case '6':
            case '7':
                if (groupSection) groupSection.style.display = 'block';
                break;
        }
    }

    function updateTableRowStatus(questionId, newStatusName) {
        const row = document.querySelector(`tbody tr[data-question-id="${questionId}"]`);
        if (!row) return;

        const statusCell = row.cells[6];
        if (statusCell) {
            let statusClass = "status-pending";
            switch (newStatusName) {
                case "Đã duyệt": statusClass = "status-approved"; break;
                case "Từ chối": statusClass = "status-rejected"; break;
                case "Cần chỉnh sửa": statusClass = "status-revision"; break;
            }
            statusCell.innerHTML = `<span class="badge ${statusClass}">${newStatusName}</span>`;
        }

        const reviewButton = row.querySelector('.action-review');
        if (reviewButton) reviewButton.remove();

        if (newStatusName === 'Đã duyệt' && !row.querySelector('.action-classify')) {
            const classifyButtonHtml = `
                <button type="button" class="btn-action action-classify" title="Phân loại" onclick="showClassifyModal(${questionId})">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-tags-fill" viewBox="0 0 16 16"><path d="M2 2a1 1 0 0 1 1-1h4.586a1 1 0 0 1 .707.293l7 7a1 1 0 0 1 0 1.414l-4.586 4.586a1 1 0 0 1-1.414 0l-7-7A1 1 0 0 1 2 6.586zm4.5 0a1.5 1.5 0 1 0 0 3 1.5 1.5 0 0 0 0-3"/><path d="M1.293 7.793A1 1 0 0 1 1 7.086V2a1 1 0 0 0-1 1v4.586a1 1 0 0 0 .293.707l7 7a1 1 0 0 0 1.414 0l.043-.043z"/></svg>
                </button>`;
            const actionsCell = row.querySelector('.actions');
            if (actionsCell) actionsCell.insertAdjacentHTML('beforeend', classifyButtonHtml);
        }
    }

    function fetchQuestionDetails(id) {
        return fetch(`/api/questions/${id}`)
            .then(response => {
                if (!response.ok) {
                    return response.text().then(text => { throw new Error(text || `Lỗi mạng: ${response.status}`) });
                }
                return response.json();
            });
    }

    function fetchCurrentClassification(id) {
        return fetch(`/api/questions/${id}/classification`)
            .then(response => {
                if (!response.ok) {
                    throw new Error(`Lỗi mạng: ${response.status}`);
                }
                return response.json();
            });
    }

})(); // Kết thúc IIFE