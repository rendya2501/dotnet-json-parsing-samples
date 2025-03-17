using System.Text.Json.Nodes;

namespace JsonParsingSample.Samples;

/// <summary>
/// System.Text.Json.Nodes.JsonNode を使用する方法
/// </summary>
/// <remarks>
/// 方法4
/// https://qiita.com/hqf00342/items/6dd97a99c5c46c14e0e4
/// </remarks>
class SystemTextJsonNodesJsonNodeSample
{
    public static void Run()
    {
        string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "src/Settings/hoge.json");
        string jsonContent = File.ReadAllText(jsonFilePath);

        var node = JsonNode.Parse(jsonContent);
        Console.WriteLine($"Name: root");
        Console.WriteLine($"Path: {node.GetPath()}");
        Console.WriteLine($"Type: {node.GetType().Name}");

        DisplayJsonNodeRecursively(node);


        var mySetting = node?["MySetting"]?.GetValue<string>() ?? "未設定";
        Console.WriteLine($"MySetting: {mySetting}");

        var connectionString1 = node?["ConnectionStrings"];
        var connectionString2 = node?["ConnectionStrings"]?["DefaultConnection"]?.GetValue<string>() ?? "未設定";
        Console.WriteLine($"接続文字列1: {connectionString1}");
        Console.WriteLine($"接続文字列2: {connectionString2}");
    }


    static void DisplayJsonNodeRecursively(JsonNode node, int level = 0)
    {
        if (node is JsonObject)
        {
            string indent = new string('\t', ++level);
            foreach (var child in node.AsObject())
            {
                Console.WriteLine($"{indent}Name: {child.Key}");
                Console.WriteLine($"{indent}Path: {child.Value.GetPath()}");
                Console.WriteLine($"{indent}Type: {child.Value.GetType().Name}");
                DisplayJsonNodeRecursively(child.Value, level);
            }
        }

        if (node is JsonArray)
        {
            string indent = new string('\t', ++level);
            foreach (var child in node.AsArray())
            {
                Console.WriteLine($"{indent}Path: {child?.GetPath()}");
                Console.WriteLine($"{indent}Type: {child?.GetType().Name}");
                DisplayJsonNodeRecursively(child, level);
            }
        }

        if (node is JsonValue)
        {
            string indent = new('\t', level);
            Console.WriteLine($"{indent}Value: {node.AsValue()}");
        }
    }

}