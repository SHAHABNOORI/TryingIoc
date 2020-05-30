using System;

namespace TryingIoc.ConsoleUi
{
    public interface IRandomGuidProvider
    {
        Guid RandomGuid { get; }
    }
}