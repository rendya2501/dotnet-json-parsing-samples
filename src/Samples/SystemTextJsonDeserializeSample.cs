using System.Text.Json;

namespace JsonParsingSample.Samples;

/// <summary>
/// System.Text.Json Deserialize を使用する方法
/// </summary>
/// <remarks>
/// 方法3
/// </remarks>
class SystemTextJsonDeserializeSample
{
    public static void Run()
    {
        string jsonContent = File.ReadAllText("Settings/hoge.json");
        var appConfig = JsonSerializer.Deserialize<AppConfig>(jsonContent);

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