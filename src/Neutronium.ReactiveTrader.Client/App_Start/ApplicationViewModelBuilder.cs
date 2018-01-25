using System.Windows;
using Adaptive.ReactiveTrader.Client.Configuration;
using Adaptive.ReactiveTrader.Client.Domain;
using Adaptive.ReactiveTrader.Shared.Logging;
using CommonServiceLocator;
using Neutronium.ReactiveTrader.Client.Application.LifeCycleHook;
using Neutronium.ReactiveTrader.Client.Application.Navigation;
using Neutronium.ReactiveTrader.Client.Application.WindowServices;
using Neutronium.ReactiveTrader.Client.ViewModel;
using Neutronium.WPF.ViewModel;

namespace Neutronium.ReactiveTrader.Client {
    public class ApplicationViewModelBuilder {
        public ApplicationViewModel ApplicationViewModel { get; }
        private readonly LifeCycleEventsRegistror _LifeCycleEventsRegistror;

        public ApplicationViewModelBuilder(Window wpfWindow) {
            var window = new WindowViewModel(wpfWindow);
            var routeSolver = RoutingConfiguration.Register();
            var serviceLocatorBuilder = new DependencyInjectionConfiguration();
            var serviceLocator = serviceLocatorBuilder.GetServiceLocator();
            serviceLocatorBuilder.Register<IWindowViewModel>(window);

            var navigation = NavigationViewModel.Create(serviceLocator, routeSolver);

            serviceLocatorBuilder.Register<INavigator>(navigation);
            serviceLocatorBuilder.Register(navigation);

            ApplicationViewModel = serviceLocator.GetInstance<ApplicationViewModel>();
            serviceLocatorBuilder.Register<IMessageBox>(ApplicationViewModel);
            serviceLocatorBuilder.Register<INotificationSender>(ApplicationViewModel);

            _LifeCycleEventsRegistror = RegisterLifeCycleEvents(serviceLocator);

            var reactiveTraderApi = serviceLocator.GetInstance<IReactiveTrader>();
            var username = serviceLocator.GetInstance<IUserProvider>().Username;
            reactiveTraderApi.Initialize(username, serviceLocator.GetInstance<IConfigurationProvider>().Servers, serviceLocator.GetInstance<ILoggerFactory>());
        }

        private static LifeCycleEventsRegistror RegisterLifeCycleEvents(IServiceLocator serviceLocator) {
            var registor = serviceLocator.GetInstance<LifeCycleEventsRegistror>();
            return registor.Register();
        }
    }
}
