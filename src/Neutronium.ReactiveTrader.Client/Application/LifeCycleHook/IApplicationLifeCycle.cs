using System.ComponentModel;
using Neutronium.ReactiveTrader.Client.Application.Navigation;

namespace Neutronium.ReactiveTrader.Client.Application.LifeCycleHook {
    public interface IApplicationLifeCycle {
        void OnNavigating(RoutingEventArgs routingEvent);

        void OnNavigated(RoutedEventArgs routedEvent);

        void OnClosing(CancelEventArgs cancelEvent);

        void OnSessionEnding(CancelEventArgs cancelEvent);

        void OnClosed();
    }
}
