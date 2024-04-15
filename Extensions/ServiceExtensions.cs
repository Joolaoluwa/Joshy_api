using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joshy_api.Extensions;

    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(myoptions =>
            {
                myoptions.AddPolicy("MyCorsPolicy", myBuilder =>
                myBuilder.AllowAnyMethod()
                .AllowAnyHeader()
                .AllowAnyOrigin());
            });
        }
    }