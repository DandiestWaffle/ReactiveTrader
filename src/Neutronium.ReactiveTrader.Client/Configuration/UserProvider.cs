using System;

namespace Adaptive.ReactiveTrader.Client.Configuration
{
    internal class UserProvider : IUserProvider
    {
        public string Username
        {
            get { return "NEUT-" + new Random().Next(1000); }
        }
    }
}