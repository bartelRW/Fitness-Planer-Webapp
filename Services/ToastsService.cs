using BlazorBootstrap;

namespace FitnessPlaner.Services
{
    public class ToastsService
    {
        List<ToastMessage> ToastMessages = new List<ToastMessage>();
        public void ShowMessage(ToastType toastType, string title, string message, List<ToastMessage> toastMessages) => toastMessages.Add(CreateToastMessage(toastType, title, message));
        private ToastMessage CreateToastMessage(ToastType toastType, string title, string message) => new ToastMessage
        {
            Type = toastType,
            Title = title,
            HelpText = $"{DateTime.Now:HH:mm}",
            Message = message,
        };
    }
}
