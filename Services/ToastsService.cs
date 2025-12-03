using BlazorBootstrap;

namespace FitnessPlaner.Services
{
    public class ToastsService
    {
        public List<ToastMessage> Messages = new();
        public void ShowMessage(ToastType toastType, string title, string message) => Messages.Add(CreateToastMessage(toastType, title, message));
        private ToastMessage CreateToastMessage(ToastType toastType, string title, string message) => new ToastMessage
        {
            Type = toastType,
            Title = title,
            HelpText = $"{DateTime.Now:HH:mm}",
            Message = message,
        };
    }
}
