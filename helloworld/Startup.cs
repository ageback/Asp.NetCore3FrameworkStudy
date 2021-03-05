﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloworld
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) => services
            .AddRouting()
            .AddControllersWithViews();

        public void Configure(IApplicationBuilder app) => app
            .UseRouting()
            .UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
