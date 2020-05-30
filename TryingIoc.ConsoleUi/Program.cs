using System;

namespace TryingIoc.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new DiServiceCollection();

            //services.RegisterSingleton<RandomGuidGenerator>();
            //services.RegisterSingleton(new RandomGuidGenerator());
            services.RegisterTransient<RandomGuidGenerator>();
            //services.RegisterTransient<ISomeService,SomeSeerviceOne>();
            services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();
            services.RegisterTransient<ISomeService, TestService>();
            services.RegisterSingleton<MainApp>();
            //services.RegisterTransient<IRandomGuidProvider, RandomGuidProvider>();

            var container = services.BuidContainer();

            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();
            serviceFirst.PrintSomthing();
            serviceSecond.PrintSomthing();
            //var mainApp = container.GetService<MainApp>();

        }
    }
}
