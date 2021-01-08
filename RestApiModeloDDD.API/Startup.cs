using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RestApiModeloDDD.Infrastructure.Crosscutting.IOC;
using RestApiModeloDDD.Infrastructure.Data;

namespace RestApiModeloDDD.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StoreContext>(options =>
                options.UseSqlServer(Configuration["SqlConnection:SqlConnectionString"])
            );
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerGen(x =>
                x.SwaggerDoc("v1", new OpenApiInfo() { Title = "API DDD Model", Version = "v1" })
            ); 
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new IOCModule());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(x =>
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "API DDD Model")
            );

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}