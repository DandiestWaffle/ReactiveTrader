using System.Reactive.Concurrency;
using Adaptive.ReactiveTrader.Client.Concurrency;

namespace Neutronium.ReactiveTrader.Client.Concurrency
{
    public sealed class ConcurrencyService : IConcurrencyService
    {
        public IScheduler Dispatcher
        {
            get { return DispatcherScheduler.Current; }
        }

        public IScheduler TaskPool
        {
            get { return ThreadPoolScheduler.Instance; }
        }

    }
}