using System;

namespace TryingIoc.ConsoleUi
{
    public class TestService : ISomeService
    {
        private readonly IRandomGuidProvider _randomGuidProvider;

        public TestService(IRandomGuidProvider randomGuidProvider)
        {
            _randomGuidProvider = randomGuidProvider;
        }

        public void PrintSomthing()
        {
            Console.WriteLine(_randomGuidProvider.RandomGuid);
        }
    }
}