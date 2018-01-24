using System.ComponentModel;
using Neutronium.ReactiveTrader.Client.Application.LifeCycleHook;
using Neutronium.ReactiveTrader.Client.Application.Navigation;
using Neutronium.ReactiveTrader.Client.Application.WindowServices;
using Vm.Tools.Application;

namespace Neutronium.ReactiveTrader.Client {
    public class ApplicationLifeCycle : IApplicationLifeCycle {
        private readonly IMessageBox _MessageBox;
        private readonly IApplication _Application;

        public ApplicationLifeCycle(IMessageBox messageBox, IApplication application) {
            _MessageBox = messageBox;
            _Application = application;
        }

        public void OnNavigating(RoutingEventArgs routingEvent) {
        }

        public void OnNavigated(RoutedEventArgs routedEvent) {
        }

        public async void OnClosing(CancelEventArgs cancelEvent) {
            cancelEvent.Cancel = true;
            var confirmationMessage = new ConfirmationMessage(Resource.ConfirmationNeeded, Resource.DoYouWantToCloseApplication);
            var close = await _MessageBox.ShowMessage(confirmationMessage);
            if (close)
                _Application.ForceClose();
        }

        public void OnSessionEnding(CancelEventArgs cancelEvent) {
        }

        public void OnClosed() {
        }
    }
}
