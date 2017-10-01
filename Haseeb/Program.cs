using System;
using Starcounter;
using Haseeb.Configs;

namespace Haseeb
{
    class Program
    {
        static void Main()
        {
            var routes = new RouteConfig();
            routes.RegisterRoutes();
        }
    }
}