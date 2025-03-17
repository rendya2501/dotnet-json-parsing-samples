using System.Text.Json;

namespace JsonParsingSample.Samples;

/// <summary>
/// System.Text.Json.JsonDocument を使用する方法
/// </summary>
/// <remarks>
/// 方法2
/// </remarks>
class SystemTextJsonJsonDocumentSample
{
    public static void Run()
    {
        string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "src/Settings/hoge.json");
        string jsonContent = File.ReadAllText(jsonFilePath);

        using (JsonDocument document = JsonDocument.Parse(jsonContent))
        {
            JsonElement root = document.RootElement;

            var MySetting = root.GetProperty("MySetting").GetString();
            var defaultConnection = root.GetProperty("ConnectionStrings").GetProperty("DefaultConnection").GetString();
            var appSettings = root.GetProperty("AppSettings");
            string appNameJson = appSettings.GetProperty("AppName").GetString();
            bool isEnabledJson = appSettings.GetProperty("IsEnabled").GetBoolean();

            Console.WriteLine($"MySetting: {MySetting}");
            Console.WriteLine($"接続文字列: {defaultConnection}");
            Console.WriteLine($"アプリ名: {appNameJson}");
            Console.WriteLine($"有効かどうか: {isEnabledJson}");

            var smtp = root.GetProperty("Smtp");
            string smtpServerJson = smtp.GetProperty("Server").GetString();
            int smtpPortJson = smtp.GetProperty("Port").GetInt32();

            Console.WriteLine($"SMTPサーバー: {smtpServerJson}");
            Console.WriteLine($"SMTPポート: {smtpPortJson}");
        }
    }
}