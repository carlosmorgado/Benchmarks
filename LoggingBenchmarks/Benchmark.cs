using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;

namespace BenchmarksRunner
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        private readonly ILoggerFactory loggerFactory;
        private const string BaseMessage = "Test Log Message";
        private const string ParameterMessage = "Test Log Message with parameters {param1} {param2} {param3}";

        public Benchmark()
        {
            this.loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("SampleApp.Program", LogLevel.Debug)
                    .AddConsole();
            });
        }

        public IEnumerable<ILogger<Benchmark>> Loggers()
        {
            yield return this.loggerFactory.CreateLogger<Benchmark>();
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Loggers))]
        public void LogInformation(ILogger<Benchmark> logger)
        {
            logger.LogInformation("Test Log Message");
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LogInformationWithTemplate(ILogger<Benchmark> logger)
        {
            logger.LogInformation(BaseMessage);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LoggerMessageWithLogNewEventId(ILogger<Benchmark> logger)
        {
            logger.LogNewEventId();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LoggerMessageWithLogExistingEventId(ILogger<Benchmark> logger)
        {
            logger.LogExistingEventId();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LoggerMessageWithLogExistingEventIdAndTemplate(ILogger<Benchmark> logger)
        {
            logger.LogExistingEventIdAndTemplate();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LogInformationWithParametersAndStringInterpolation(ILogger<Benchmark> logger)
        {
            const string param1 = "param1";
            const string param2 = "param2";
            const string param3 = "param3";
            logger.LogInformation($"Test Log Message with parameters {param1} {param2} {param3}");
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LogInformationWithParametersAndString(ILogger<Benchmark> logger)
        {
            const string param1 = "param1";
            const string param2 = "param2";
            const string param3 = "param3";
            logger.LogInformation("Test Log Message with parameters {param1} {param2} {param3}", param1, param2, param3);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LogInformationWithParametersAndStringWithTemplate(ILogger<Benchmark> logger)
        {
            const string param1 = "param1";
            const string param2 = "param2";
            const string param3 = "param3";
            logger.LogInformation(ParameterMessage, param1, param2, param3);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LoggerMessageWithParametersAndStringWithNewEventId(ILogger<Benchmark> logger)
        {
            const string param1 = "param1";
            const string param2 = "param2";
            const string param3 = "param3";
            logger.LogNewEventIdAndParameters(param1, param2, param3);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LoggerMessageWithParametersAndStringWithExistingEventId(ILogger<Benchmark> logger)
        {
            const string param1 = "param1";
            const string param2 = "param2";
            const string param3 = "param3";
            logger.LogExistingEventIdAndParameters(param1, param2, param3);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Loggers))]
        public void LoggerMessageWithParametersAndStringWithExistingEventIdAndTemplate(ILogger<Benchmark> logger)
        {
            const string param1 = "param1";
            const string param2 = "param2";
            const string param3 = "param3";
            logger.LogExistingEventIdAndTemplateAndParameters(param1, param2, param3);
        }
    }
}
