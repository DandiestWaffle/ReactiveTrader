using CommonServiceLocator;

namespace Neutronium.ReactiveTrader.Client {
    public interface IDependencyInjectionConfiguration {
        IServiceLocator GetServiceLocator();

        void Register<T>(T implementation) where T: class;
    }
}