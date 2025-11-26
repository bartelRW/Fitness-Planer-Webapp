// Close a Bootstrap modal by its ID
function closeModal(modalId) {
    const modalEl = document.getElementById(modalId);
    const modal = bootstrap.Modal.getInstance(modalEl);
    if (modal) {
        modal.hide();
    }
}

// Open a Bootstrap modal by its ID
function openModal (modalId) {
    const modalEl = document.getElementById(modalId);
    if (!modalEl) return;
    const modal = new bootstrap.Modal(modalEl);
    modal.show();
};
