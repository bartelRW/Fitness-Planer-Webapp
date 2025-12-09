// Initializes a Chart.js chart on a given canvas element using provided configuration.
window.renderChart = (canvasId, chartConfig) => {
    const ctx = document.getElementById(canvasId).getContext('2d');
    new Chart(ctx, chartConfig);
};