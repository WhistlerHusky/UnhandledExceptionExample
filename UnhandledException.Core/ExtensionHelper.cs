using System;

namespace UnhandledException.Core
{
    public static class ExtensionHelper
    {
        public static string GetInnerExceptionMessage(this Exception e)
        {
            return e.Message + e.InnerException?.GetInnerExceptionMessage();
        }
    }
}
