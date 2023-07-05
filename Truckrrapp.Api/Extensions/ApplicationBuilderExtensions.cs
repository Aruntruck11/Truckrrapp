using Microsoft.AspNetCore.Builder;

namespace Truckrrapp.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Truckrrapp.Api");
                options.RoutePrefix = "swagger";
                options.DisplayRequestDuration();
            });
        }
    }
}