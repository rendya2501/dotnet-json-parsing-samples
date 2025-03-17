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
        string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "src/Settings/hoge.json");
        string jsonContent = File.ReadAllText(jsonFilePath);

        var appConfig = JsonSerializer.Deserialize<AppConfig>(jsonContent);

        Console.WriteLine($"MySetting: {appConfig.MySetting}");
        Console.WriteLine($"接続文字列: {appConfig.ConnectionStrings.DefaultConnection}");
        Console.WriteLine($"アプリ名: {appConfig.AppSettings.AppName}");
        Console.WriteLine($"有効かどうか: {appConfig.AppSettings.IsEnabled}");
        Console.WriteLine($"SMTPサーバー: {appConfig.Smtp.Server}");
        Console.WriteLine($"SMTPポート: {appConfig.Smtp.Port}");
    }
}