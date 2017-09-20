﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StatlerWaldorfCorp.TeamService.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatlerWaldorfCorp.TeamService
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<ITeamRepository, MemoryTeamRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
