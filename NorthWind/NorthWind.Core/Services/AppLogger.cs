using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Core.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writers) : IAppLogger
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach (var Writer in writers)
                Writer.Write(Log);
        }
    }
}
