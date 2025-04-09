using MerchantApi.Middleware;
using MerchantApi.Services;

namespace MerchantApi;

public class Startup
{
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        
        services.AddSwaggerGen();
        services.AddScoped<IMerchantService, FakeMerchantService>();
        services.AddScoped<IUserService, FakeUserService>();
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
   
        app.UseHttpsRedirection();
        
        app.UseRouting();
        
        app.UseAuthorization();
        app.UseMiddleware<ExceptionMiddleware>();
        app.UseMiddleware<LoggingMiddleware>();
        
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}