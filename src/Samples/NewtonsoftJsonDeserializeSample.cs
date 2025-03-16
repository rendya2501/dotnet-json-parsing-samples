using Newtonsoft.Json;

namespace JsonParsingSample.Samples;

/// <summary>
/// Newtonsoft.Json のDeserializeを使用する方法
/// </summary>
/// <remarks>
/// 方法6
/// </remarks>
class NewtonsoftJsonDeserializeSample
{
    public static void Run()
    {
        string jsonContent = File.ReadAllText("Settings/hoge.json");
        var appConfig = JsonConvert.DeserializeObject<AppConfig>(jsonContent);

        Console.WriteLine($"MySetting: {appConfig.MySetting}");
        Console.WriteLine($"接続文字列: {appConfig.ConnectionStrings.DefaultConnection}");
        Console.WriteLine($"アプリ名: {appConfig.AppSettings.AppName}");
        Console.WriteLine($"有効かどうか: {appConfig.AppSettings.IsEnabled}");
        Console.WriteLine($"SMTPサーバー: {appConfig.Smtp.Server}");
        Console.WriteLine($"SMTPポート: {appConfig.Smtp.Port}");
    }



    public class AppConfig
    {
        public string MySetting { get; set; }
        public ConnectionStringsConfig ConnectionStrings { get; set; }
        public AppSettingsConfig AppSettings { get; set; }
        public SmtpConfig Smtp { get; set; }
    }

    public class ConnectionStringsConfig
    {
        public string DefaultConnection { get; set; }
    }

    public class AppSettingsConfig
    {
        public string AppName { get; set; }
        public bool IsEnabled { get; set; }
    }

    public class SmtpConfig
    {
        public string Server { get; set; }
        public int Port { get; set; }
    }
}