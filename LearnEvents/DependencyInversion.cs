using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LearnEvents
{
    public static class DependencyInversions
    {
        public static IServiceCollection AddFileWatcher(this IServiceCollection services)
        {
            services.AddHostedService<FileWatcherService>();
            services.AddSingleton<FileWatcherSender>();
            services.AddSingleton<FileWatcherSubscriber>();
            return services;
        }
    }
}
