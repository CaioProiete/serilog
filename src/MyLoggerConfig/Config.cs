using Serilog;

namespace MyLoggerConfig
{
    public static class LoggerConfig
    {
        public static ILogger ConfigureLogging()
        {
            return new LoggerConfiguration()
                .WriteTo.Seq("https://seq.mycompany.com")
                .CreateLogger();
        }
    }
}
