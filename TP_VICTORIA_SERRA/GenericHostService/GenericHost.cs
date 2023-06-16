using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.GenericHostService
{
    internal class GenericHost
    {
        public void create()
        {
            Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHostedService<HostedService>();
                })
                .Build()
                .Run();

        }
    }
}
