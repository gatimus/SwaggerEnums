using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SwaggerEnums.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace SwaggerEnums
{
    public class Startup
    {
   
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
                .AddApiExplorer();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                // c.MapType<MyEnum>(() => new Schema { Ref = "#/definitions/MyEnum" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();

            app.UseSwagger();
        }
    }
}
