namespace Neutronium.ReactiveTrader.Client.Application.WindowServices {
    public interface INotificationSender {
        void Send(Notification notification);
    }
}
