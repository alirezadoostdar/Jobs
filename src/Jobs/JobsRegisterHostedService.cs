using Hangfire;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Jobs
{
    public class JobsRegisterHostedService(IOptions<AppSettings> options, IServiceScopeFactory scopeFactory) : IHostedService
    {
        private readonly JobSettings jobSettings = options.Value.JobSettings;
        public Task StartAsync(CancellationToken cancellationToken)
        {
            RecurringJob.AddOrUpdate<alert>
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
