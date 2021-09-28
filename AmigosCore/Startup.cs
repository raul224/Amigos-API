using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCore
{
    public static class Startup
    {
        public static void AddAplicationCore(this IServiceCollection services)
        {
            services.AddScoped<AmigoService>();
        }
    }
}
