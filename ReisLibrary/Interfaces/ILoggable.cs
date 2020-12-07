using ReisLibrary.Models;

namespace ReisLibrary.Interfaces
{
   public interface ILoggable
    {
        //void LogMessage(string message);
        LogMessage LogMessage { get; }
    }
}
