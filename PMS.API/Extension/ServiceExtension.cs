using Microsoft.EntityFrameworkCore;
using PMS.BusinessObjects.Context;
using PMS.BusinessObjects.Entities;
using PMS.Repositories.Implementation;
using PMS.Repositories.Interface;
using PMS.Services.Implementation;
using PMS.Services.Interface;

namespace PMS.API.Extension;

public static class ServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });
    
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
        });
    
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<MyDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    public static void ConfigureRepositoryManager(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        services.AddScoped<ISaleOrderRepository, SaleOrderRepository>();
        services.AddScoped<ISaleOrderDetailRepository, SaleOrderDetailRepository>();
    }
    
    public static void ConfigureServiceManager(this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductCategoryService, ProductCategoryService>();
        services.AddScoped<ISaleOrderService, SaleOrderService>();
        services.AddScoped<ISaleOrderDetailService, SaleOrderDetailService>();
    }
        
}