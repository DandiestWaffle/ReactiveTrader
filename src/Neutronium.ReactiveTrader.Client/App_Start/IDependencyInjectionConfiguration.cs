using Microsoft.Practices.ServiceLocation;

namespace Neutronium.ReactiveTrader.Client {
    public interface IDependencyInjectionConfiguration {
        IServiceLocator GetServiceLocator();

        void Register<T>(T implementation);
    }
}