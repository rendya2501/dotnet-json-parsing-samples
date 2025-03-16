using Newtonsoft.Json.Linq;

namespace JsonParsingSample.Samples;

/// <summary>
/// Newtonsoft.Json のJObjectを使用する方法
/// </summary>
/// <remarks>
/// 方法5
/// </remarks>
class NewtonsoftJsonJObjectSample
{
    public static void Run()
    {
        string jsonContent = File.ReadAllText("Settings/hoge.json");
        JObject jsonObject = JObject.Parse(jsonContent);

        string mySetting = jsonObject["MySetting"].Value<string>();
        string connectionString = (string)jsonObject["ConnectionStrings"]["DefaultConnection"];
        string appName1 = jsonObject["AppSettings"]["AppName"].Value<string>();
        string appName2 = jsonObject.SelectToken("AppSettings.AppName").Value<string>();
        string appName3 = jsonObject.SelectToken("AppSettings").SelectToken("AppName").Value<string>();
        bool isEnabled = (bool)jsonObject["AppSettings"]["IsEnabled"];

        Console.WriteLine($"MySetting: {mySetting}");
        Console.WriteLine($"接続文字列: {connectionString}");
        Console.WriteLine($"アプリ名 配列アクセス: {appName1}");
        Console.WriteLine($"アプリ名 SelectToken1: {appName2}");
        Console.WriteLine($"アプリ名 SelectToken2: {appName2}");
        Console.WriteLine($"有効かどうか: {isEnabled}");

        JToken smtpSection = jsonObject["Smtp"];
        string smtpServer = (string)smtpSection["Server"];
        int smtpPort = (int)smtpSection["Port"];

        Console.WriteLine($"SMTPサーバー: {smtpServer}");
        Console.WriteLine($"SMTPポート: {smtpPort}");
    }
}