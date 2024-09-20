namespace Jobs;

public static class JobQueues
{
    public const string Priority1 = "high";
    public const string Priority2 = "low";
}

public class AlertSmsPanelJob(HttpClient httpClient,ILogger<AlertSmsPanelJob> logger)
{
    public const string JobName = "alert_sms_panel_job";
    private readonly HttpClient _httpClient = httpClient;
    private readonly ILogger<AlertSmsPanelJob> _logger = logger;

    public async Task ExecuteAsync()
    {
        try
        {
            _logger.LogInformation("check sms panel balance");
            //_httpClient
            await Task.Delay(1000);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "message!");
        }
    }
}
