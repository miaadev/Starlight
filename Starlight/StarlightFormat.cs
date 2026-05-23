namespace Starlight
{
    public class StarlightFormat
    {
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string CrashMessage { get; set; }
        public string CrashType { get; set; }
        public string CrashLogPath { get; set; }
        public string CrashLogFile { get; set; }
    }

    public class StarlightViewerFormat
    {
        public StarlightFormat starlight { get; set; }
        public string GUID { get; set; }
        public string LogContent { get; set; }

    }
}