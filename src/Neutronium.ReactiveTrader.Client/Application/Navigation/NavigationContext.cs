using System;

namespace Neutronium.ReactiveTrader.Client.Application.Navigation {
    public class NavigationContext {
        public string ResolutionKey { get; set; }
        public string RouteName { get; set; }
    }

    public class NavigationContext<T> : NavigationContext {
        public Action<T> BeforeNavigate { get; set; }
    }
}