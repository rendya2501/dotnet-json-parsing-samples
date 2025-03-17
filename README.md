# dotnet-json-parsing-samples

.NETでのJSON読み取りライブラリの使い方サンプル

``` txt
方法1: IConfiguration を使用
接続文字列: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;
アプリ名1: MyApp
アプリ名2: MyApp
アプリ名3: MyApp
有効かどうか: True
SMTPサーバー: smtp.example.com
SMTPポート: 25

-------------------------------

方法2: System.Text.Json JsonDocument を使用
MySetting: Hello,World!
接続文字列: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;
アプリ名: MyApp
有効かどうか: True
SMTPサーバー: smtp.example.com
SMTPポート: 25

-------------------------------

方法3: System.Text.Json Deserialize を使用
MySetting: Hello,World!
接続文字列: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;
アプリ名: MyApp
有効かどうか: True
SMTPサーバー: smtp.example.com
SMTPポート: 25

-------------------------------

方法4: System.Text.Json.Nodes.JsonNode を使用
Name: root
Path: $
Type: JsonObject
        Name: MySetting
        Path: $.MySetting
        Type: JsonValueOfElement
        Value: Hello,World!
        Name: ConnectionStrings
        Path: $.ConnectionStrings
        Type: JsonObject
                Name: DefaultConnection
                Path: $.ConnectionStrings.DefaultConnection
                Type: JsonValueOfElement
                Value: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;
        Name: AppSettings
        Path: $.AppSettings
        Type: JsonObject
                Name: AppName
                Path: $.AppSettings.AppName
                Type: JsonValueOfElement
                Value: MyApp
                Name: IsEnabled
                Path: $.AppSettings.IsEnabled
                Type: JsonValueOfElement
                Value: true
        Name: Smtp
        Path: $.Smtp
        Type: JsonObject
                Name: Server
                Path: $.Smtp.Server
                Type: JsonValueOfElement
                Value: smtp.example.com
                Name: Port
                Path: $.Smtp.Port
                Type: JsonValueOfElement
                Value: 25
MySetting: Hello,World!
接続文字列1: {
  "DefaultConnection": "Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;"
}
接続文字列2: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;

-------------------------------

方法5: Newtonsoft.Json JObject を使用
MySetting: Hello,World!
接続文字列: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;
アプリ名 配列アクセス: MyApp
アプリ名 SelectToken1: MyApp
アプリ名 SelectToken2: MyApp
有効かどうか: True
SMTPサーバー: smtp.example.com
SMTPポート: 25

-------------------------------

方法6: Newtonsoft.Json Deserialize を使用
MySetting: Hello,World!
接続文字列: Server=localhost;Database=myDb;User Id=sa;Password=yourPassword;
アプリ名: MyApp
有効かどうか: True
SMTPサーバー: smtp.example.com
SMTPポート: 25
```
