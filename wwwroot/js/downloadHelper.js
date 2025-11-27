// Enable file download from content stream reference
async function downloadFileFromStream (fileName, contentStreamReference) {

    // Convert the content stream reference to a Blob
    const arrayBuffer = await contentStreamReference.arrayBuffer();
    const blob = new Blob([arrayBuffer]);
    const url = URL.createObjectURL(blob);

    // Create a temporary anchor element to trigger the download
    const anchorElement = document.createElement('a');
    anchorElement.href = url;
    anchorElement.download = fileName || 'download.csv';
    anchorElement.click();

    // Clean up the URL object
    URL.revokeObjectURL(url);
};