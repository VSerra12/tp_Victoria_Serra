using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.GenericHostService
{
    internal class HostedService : IHostedService
    {
        private Task done = Task.CompletedTask;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var logger = LoggerFactory.Create(config =>
            {
                config.AddConsole();
            }).CreateLogger("Program");
            logger.LogInformation("Work in progress");
            return done;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return done;
        }
    }
}
