using Serilog;

namespace TestTransitiveDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var log = Log.Logger = MyLoggerConfig.LoggerConfig.ConfigureLogging();
                log.Information("Hello");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
