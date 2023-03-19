namespace Microsoft.Extensions.Logging
{
    internal static partial class LoggingExtensions
    {
        [LoggerMessage(
            120,
            LogLevel.Information,
            "Test Log Message",
            SkipEnabledCheck = true)]
        public static partial void LogNewEventId(this ILogger logger);

        [LoggerMessage(
            EventIds.LogExistingEventId,
            LogLevel.Information,
            "Test Log Message",
            SkipEnabledCheck = true)]
        public static partial void LogExistingEventId(this ILogger logger);

        [LoggerMessage(
            EventIds.LogExistingEventIdAndTemplate,
            LogLevel.Information,
            Messages.BaseMessage,
            SkipEnabledCheck = true)]
        public static partial void LogExistingEventIdAndTemplate(this ILogger logger);

        [LoggerMessage(
            123,
            LogLevel.Information,
            "Test Log Message with parameters {param1} {param2} {param3}",
            SkipEnabledCheck = true)]
        public static partial void LogNewEventIdAndParameters(
            this ILogger logger,
            string param1,
            string param2,
            string param3);

        [LoggerMessage(
            EventIds.LogExistingEventIdAndParameters,
            LogLevel.Information,
            "Test Log Message with parameters {param1} {param2} {param3}",
            SkipEnabledCheck = true)]
        public static partial void LogExistingEventIdAndParameters(
            this ILogger logger,
            string param1,
            string param2,
            string param3);

        [LoggerMessage(
            EventIds.LogExistingEventIdAndTemplateAndParameters,
            LogLevel.Information,
            Messages.ParameterMessage,
            SkipEnabledCheck = true)]
        public static partial void LogExistingEventIdAndTemplateAndParameters(
            this ILogger logger,
            string param1,
            string param2,
            string param3);
    }

    internal static class EventIds
    {
        public const int LogExistingEventId = 121;
        public const int LogExistingEventIdAndTemplate = 122;
        public const int LogExistingEventIdAndParameters = 124;
        public const int LogExistingEventIdAndTemplateAndParameters = 125;
    }

    internal static class Messages
    {
        public const string BaseMessage = "Test Log Message";
        public const string ParameterMessage = "Test Log Message with parameters {param1} {param2} {param3}";
    }
}
