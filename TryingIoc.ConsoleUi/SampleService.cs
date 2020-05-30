using System;

namespace TryingIoc.ConsoleUi
{
    public class SampleService : ISomeService
    {
        private readonly Guid _randomGuid = Guid.NewGuid();
        public void PrintSomthing()
        {
            Console.WriteLine($"This is another service :: {_randomGuid}");
        }
    }
}