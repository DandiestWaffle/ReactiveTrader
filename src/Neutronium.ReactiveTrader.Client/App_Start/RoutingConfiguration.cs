using Adaptive.ReactiveTrader.Client.UI.Shell;
using Neutronium.Core.Navigation.Routing;
using Neutronium.ReactiveTrader.Client.Application.Navigation;

namespace Neutronium.ReactiveTrader.Client {
    public class RoutingConfiguration {
        public static IRouterSolver Register() {
            var router = new Router();
            BuildRoutes(router);
            return router;
        }

        private static void BuildRoutes(IRouterBuilder routeBuilder) {
            var convention = routeBuilder.GetTemplateConvention("{vm}");
            typeof(RoutingConfiguration).GetTypesFromSameAssembly()
                .InNamespace("Neutronium.ReactiveTrader.Client.ViewModel.Pages")
                .Register(convention);
            routeBuilder.Register<IShellViewModel>("main");
            routeBuilder.Register<IShellViewModel>("blot");
        }
    }
}
