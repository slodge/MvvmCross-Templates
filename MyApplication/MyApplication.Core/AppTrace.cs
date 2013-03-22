using Cirrious.CrossCore.Platform;

namespace MyApplication.Core
{
    public static class AppTrace
    {
        private const string Tag = "MyApp";

        public static MvxTraceLevel TraceLevel = MvxTraceLevel.Diagnostic;

        public static void Trace(MvxTraceLevel level, string message, params object[] args)
        {
            if (level < TraceLevel)
                return;

            MvxTrace.TaggedTrace(level, Tag, message, args);
        }

        public static void Trace(string message, params object[] args)
        {
            Trace(MvxTraceLevel.Diagnostic, Tag, message, args);
        }

        public static void Warning(string message, params object[] args)
        {
            Trace(MvxTraceLevel.Warning, Tag, message, args);
        }

        public static void Error(string message, params object[] args)
        {
            Trace(MvxTraceLevel.Error, Tag, message, args);
        }
    }
}