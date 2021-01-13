using System.Diagnostics;

namespace InstanceCtors
{
    public class ApplicationLogger
    {
        private ApplicationLogger()
        {
        }

        public static ApplicationLogger Instance { get; } = new ApplicationLogger();

        public void WriteLog(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
