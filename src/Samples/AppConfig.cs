namespace JsonParsingSample.Samples;

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