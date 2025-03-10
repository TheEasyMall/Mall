using Mall.DALs.Repositories.Implements;
using Mall.DALs.Repositories.Interfaces;
using Mall.Repositories.Implements;
using Mall.Repositories.Interfaces;
using Mall.Services.Implements;
using Mall.Services.Interfaces;

namespace Mall.MVC.Setup
{
    public class ServiceRepoMapping
    {
        public void Mapping(WebApplicationBuilder builder)
        {
            //Repositories
            builder.Services.AddScoped<ITenantRepository, TenantRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            //builder.Services.AddScoped<IVariantRepository, VariantRepository>();
            //builder.Services.AddScoped<ICartRepository, CartRepository>();
            //builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            //builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            //builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
            //builder.Services.AddScoped<IStaffRepository, StaffRepository>();

            //Services
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<ITenantService, TenantService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            //builder.Services.AddScoped<IVariantService, VariantService>();
            //builder.Services.AddScoped<ICartService, CartService>();
            //builder.Services.AddScoped<IOrderService, OrderService>();
            //builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
            //builder.Services.AddScoped<IReviewService, ReviewService>();
            //builder.Services.AddScoped<IStaffService, StaffService>();
        }
    }
}
