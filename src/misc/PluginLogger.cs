using OWML.Common;

namespace owd.OuterWilds.UncapFps
{
    internal static class PluginLogger
    {
        public static bool enableLogging = true;
        public static IModHelper Helper;

        public static void Init(IModHelper helper)
        {
            Helper = helper;
        }

        public static void LogInfo(string message)
        {
            if (!enableLogging || Helper == null) return;
            Helper.Console.WriteLine(message, MessageType.Info);
        }

        public static void LogWarning(string message)
        {
            if (!enableLogging || Helper == null) return;
            Helper.Console.WriteLine(message, MessageType.Warning);
        }

        public static void LogError(string message)
        {
            if (!enableLogging || Helper == null) return;
            Helper.Console.WriteLine(message, MessageType.Error);
        }
    }
}