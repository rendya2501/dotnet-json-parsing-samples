using Microsoft.Extensions.Configuration;

namespace JsonParsingSample.Samples;

/// <summary>
/// Microsoft.Extensions.Configuration.Binder パッケージを使用する方法
/// </summary>
public class IConfigurationBinderSample
{
    public static void Run()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("src/Settings/hoge.json", optional: false, reloadOnChange: true)
            .Build();

        // Microsoft.Extensions.Configuration.Binder パッケージを使用することで記述可能
        var appConfig = configuration.Get<AppConfig>();
        Console.WriteLine($"MySetting: {appConfig.MySetting}");
        Console.WriteLine($"接続文字列: {appConfig.ConnectionStrings.DefaultConnection}");
        Console.WriteLine($"アプリ名: {appConfig.AppSettings.AppName}");
        Console.WriteLine($"有効かどうか: {appConfig.AppSettings.IsEnabled}");
        Console.WriteLine($"SMTPサーバー: {appConfig.Smtp.Server}");
        Console.WriteLine($"SMTPポート: {appConfig.Smtp.Port}");
    }
}