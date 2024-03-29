﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PoC.Models;

namespace PoC
{
	public class Startup
	{

		public IConfiguration Configuration{get; }

		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddDbContext<DataAccess>(options =>
			options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
			services.AddMvc();
			services.AddCors(options =>
			{
				options.AddPolicy("DefaultCorsPolicyName", builder =>
				{
					builder
						.AllowAnyOrigin()
						.AllowAnyHeader()
						.AllowAnyMethod();
				});
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseCors("DefaultCorsPolicyName");

			app.UseMvc();

			app.Run(async (context) =>
			{
				//await context.Response.WriteAsync("MVC didn't find anything!");
			});
		}
    }
}
