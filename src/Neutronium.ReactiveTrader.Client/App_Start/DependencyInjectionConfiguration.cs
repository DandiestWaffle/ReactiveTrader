using System;
using Adaptive.ReactiveTrader.Client.Concurrency;
using Adaptive.ReactiveTrader.Client.Configuration;
using Adaptive.ReactiveTrader.Client.Domain;
using Adaptive.ReactiveTrader.Client.Domain.Instrumentation;
using Adaptive.ReactiveTrader.Client.UI.Blotter;
using Adaptive.ReactiveTrader.Client.UI.Connectivity;
using Adaptive.ReactiveTrader.Client.UI.Shell;
using Adaptive.ReactiveTrader.Client.UI.SpotTiles;
using Adaptive.ReactiveTrader.Shared.Logging;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Neutronium.Core.WebBrowserEngine.Window;
using Neutronium.ReactiveTrader.Client.Application.LifeCycleHook;
using Neutronium.ReactiveTrader.Client.Concurrency;
using Neutronium.WPF.Internal;
using Vm.Tools.Application;

namespace Neutronium.ReactiveTrader.Client
{
    public class DependencyInjectionConfiguration : IDependencyInjectionConfiguration
    {
        private readonly ContainerBuilder _ContainerBuilder;
        private readonly Lazy<IServiceLocator> _ServiceLocator;

        public DependencyInjectionConfiguration()
        {
            var builder = new ContainerBuilder();
            RegisterDependency(builder);
            _ContainerBuilder = builder;
            _ServiceLocator = new Lazy<IServiceLocator>(() => new AutofacServiceLocator(_ContainerBuilder.Build()));
        }

        public IServiceLocator GetServiceLocator() => _ServiceLocator.Value;

        public void Register<T>(T implementation) where T : class
        {
            _ContainerBuilder.RegisterInstance(implementation).As<T>();
        }

        public static void RegisterDependency(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(DependencyInjectionConfiguration).Assembly);
            var window = System.Windows.Application.Current.MainWindow;
            var application = new WpfApplication(window);
            builder.RegisterInstance(application).As<IApplication>();
            builder.RegisterInstance(new WPFUIDispatcher(window.Dispatcher)).As<IDispatcher>();
            builder.RegisterType<ApplicationLifeCycle>().As<IApplicationLifeCycle>();
            //kernel.Bind<MainViewModel>().ToSelf().InSingletonScope();

            builder.RegisterType<Adaptive.ReactiveTrader.Client.Domain.ReactiveTrader>().As<IReactiveTrader>().SingleInstance();
            builder.RegisterType<DebugLoggerFactory>().As<ILoggerFactory>().SingleInstance();
            builder.RegisterType<NullProcessorMonitor>().As<IProcessorMonitor>().SingleInstance();
            builder.RegisterType<ConstantRatePump>().As<IConstantRatePump>();

            builder.RegisterType<ShellViewModel>().As<IShellViewModel>().ExternallyOwned();
            builder.RegisterType<SpotTilesViewModel>().As<ISpotTilesViewModel>().ExternallyOwned();
            builder.RegisterType<SpotTileViewModel>().As<ISpotTileViewModel>().ExternallyOwned();
            builder.RegisterType<SpotTileErrorViewModel>().As<ISpotTileErrorViewModel>().ExternallyOwned();
            builder.RegisterType<SpotTileConfigViewModel>().As<ISpotTileConfigViewModel>().ExternallyOwned();
            builder.RegisterType<SpotTilePricingViewModel>().As<ISpotTilePricingViewModel>().ExternallyOwned();
            builder.RegisterType<OneWayPriceViewModel>().As<IOneWayPriceViewModel>().ExternallyOwned();
            builder.RegisterType<SpotTileAffirmationViewModel>().As<ISpotTileAffirmationViewModel>().ExternallyOwned();
            builder.RegisterType<BlotterViewModel>().As<IBlotterViewModel>().ExternallyOwned();
            builder.RegisterType<TradeViewModel>().As<ITradeViewModel>().ExternallyOwned();
            builder.RegisterType<ConnectivityStatusViewModel>().As<IConnectivityStatusViewModel>().ExternallyOwned();
            builder.RegisterType<ConfigurationProvider>().As<IConfigurationProvider>();
            builder.RegisterType<ConstantRateConfigurationProvider>().As<IConstantRateConfigurationProvider>();
            builder.RegisterType<UserProvider>().As<IUserProvider>();
            builder.RegisterType<ConcurrencyService>().As<IConcurrencyService>();
        }
    }
}
