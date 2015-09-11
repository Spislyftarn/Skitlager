using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;

namespace Skitlager
{
    public class ApplicationSettings
    {
        public static string ApplicationBasePath { get; private set; }

        public static void Create(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var appEnv = serviceProvider.GetRequiredService<IApplicationEnvironment>();
            ApplicationBasePath = appEnv.ApplicationBasePath;
        }
    }
}
