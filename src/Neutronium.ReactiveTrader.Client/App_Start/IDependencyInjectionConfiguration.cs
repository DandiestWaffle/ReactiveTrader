using System;
using CommonServiceLocator;

namespace Neutronium.ReactiveTrader.Client {
    public interface IDependencyInjectionConfiguration {
        Lazy<IServiceLocator> GetServiceLocator();

        void Register<T>(T implementation) where T: class;
    }
}