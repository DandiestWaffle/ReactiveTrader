﻿using System.Reflection;

namespace Neutronium.ReactiveTrader.Client.ViewModel {
    public class ApplicationInformation {
        public string Name => "Reactive Trader Neutronium";

        public string Version => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string MadeBy => "David Desmaisons";

        public int Year => 2017;
    }
}
