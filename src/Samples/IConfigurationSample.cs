using Microsoft.Extensions.Configuration;

namespace JsonParsingSample.Samples;

/// <summary>
/// IConfiguration を使用する方法
/// </summary>
/// <remarks>
/// 方法1
/// </remarks>
class IConfigurationSample
{
    public static void Run()
    {
        // Microsoft.Extensions.Configuration.Json パッケージを使用する方法
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("src/Settings/hoge.json", optional: false, reloadOnChange: true)
            .Build();
            
        string connectionString = configuration.GetConnectionString("DefaultConnection");
        string appName1 = configuration["AppSettings:AppName"];
        string appName2 = configuration.GetSection("AppSettings")["AppName"];
        string appName3 = configuration.GetSection("AppSettings").GetSection("AppName").Value;
        bool isEnabled = bool.Parse(configuration["AppSettings:IsEnabled"]);

        Console.WriteLine($"接続文字列: {connectionString}");
        Console.WriteLine($"アプリ名1: {appName1}");
        Console.WriteLine($"アプリ名2: {appName2}");
        Console.WriteLine($"アプリ名3: {appName3}");
        Console.WriteLine($"有効かどうか: {isEnabled}");

        var smtpSection = configuration.GetSection("Smtp");
        string smtpServer = smtpSection["Server"];
        int smtpPort = int.Parse(smtpSection["Port"]);

        Console.WriteLine($"SMTPサーバー: {smtpServer}");
        Console.WriteLine($"SMTPポート: {smtpPort}");
    }
}