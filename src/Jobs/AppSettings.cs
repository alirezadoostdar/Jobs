using Hangfire.Redis.StackExchange;

namespace Jobs;

public class AppSettings
{
    public required JobSettings JobSettings { get; set; }
}

public class JobSettings
{
    public required ExtendedRedisStorageOptions RedisStorage { get; set; }
}

public sealed class ExtendedRedisStorageOptions : RedisStorageOptions
{
    public required string ConnectionStringe { get; set; }
}