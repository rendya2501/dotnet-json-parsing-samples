using JsonParsingSample.Samples;

Console.WriteLine("方法1: IConfiguration を使用");
IConfigurationSample.Run();

Console.WriteLine("\n-------------------------------\n");
Console.WriteLine("方法2: System.Text.Json JsonDocument を使用");
SystemTextJsonJsonDocumentSample.Run();

Console.WriteLine("\n-------------------------------\n");
Console.WriteLine("方法3: System.Text.Json Deserialize を使用");
SystemTextJsonDeserializeSample.Run();

Console.WriteLine("\n-------------------------------\n");
Console.WriteLine("方法4: System.Text.Json.Nodes.JsonNode を使用");
SystemTextJsonNodesJsonNodeSample.Run();

Console.WriteLine("\n-------------------------------\n");
Console.WriteLine("方法5: Newtonsoft.Json JObject を使用");
NewtonsoftJsonJObjectSample.Run();

Console.WriteLine("\n-------------------------------\n");
Console.WriteLine("方法6: Newtonsoft.Json Deserialize を使用");
NewtonsoftJsonDeserializeSample.Run();
