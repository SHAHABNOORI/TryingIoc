using System;

namespace TryingIoc.ConsoleUi
{
    public class SomeServiceOne : ISomeService
    {
        private readonly Guid _randomGuid = Guid.NewGuid();
        public void PrintSomthing()
        {
            Console.WriteLine(_randomGuid);
        }
    }
}