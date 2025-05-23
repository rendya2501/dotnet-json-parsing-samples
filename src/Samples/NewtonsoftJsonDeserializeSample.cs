﻿using Newtonsoft.Json;

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
        string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "src/Settings/hoge.json");
        string jsonContent = File.ReadAllText(jsonFilePath);

        var appConfig = JsonConvert.DeserializeObject<AppConfig>(jsonContent);

        Console.WriteLine($"MySetting: {appConfig.MySetting}");
        Console.WriteLine($"接続文字列: {appConfig.ConnectionStrings.DefaultConnection}");
        Console.WriteLine($"アプリ名: {appConfig.AppSettings.AppName}");
        Console.WriteLine($"有効かどうか: {appConfig.AppSettings.IsEnabled}");
        Console.WriteLine($"SMTPサーバー: {appConfig.Smtp.Server}");
        Console.WriteLine($"SMTPポート: {appConfig.Smtp.Port}");
    }
}