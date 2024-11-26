using BLL.Services;
using BLL.Services.Category;
using BLL.Services.Customer;
using BLL.Services.Dosage;
using BLL.Services.Material;
using BLL.Services.Order;
using BLL.Services.OrderDetail;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Recipe_material;
using BLL.Services.Size;
using DAL.Repositories.Category;
using DAL.Repositories.Customer;
using DAL.Repositories.Dosage;
using DAL.Repositories.Material;
using DAL.Repositories.Order;
using DAL.Repositories.OrderDetail;
using DAL.Repositories.Product;
using DAL.Repositories.ProductDetail;
using DAL.Repositories.Recipe;
using DAL.Repositories.Recipe_material;
using DAL.Repositories.Size;
using GUI.Forms;
using GUI.Forms.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace GUI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductDetailRepository, ProductDetailRepository>();
            services.AddTransient<ISizeRepository, SizeRepository>();
            services.AddTransient<IRecipeRepository, RecipeRepository>();
            services.AddTransient<IMaterialRepository, MaterialRepository>();
            services.AddTransient<IRecipe_materialRepository, Recipe_materialRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
            services.AddTransient<IDosageRepository, DosageRepository>();


        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductDetailService, ProductDetailService>();
            services.AddTransient<ISizeService, SizeService>();
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddTransient<IMaterialService, MaterialService>();
            services.AddTransient<IRecipe_materialService, Recipe_materialService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();
            services.AddTransient<IDosageService, DosageService>();




        }
        public static void AddForms(this IServiceCollection services)
        {
            // Đăng ký form frmLogin vào DI container
            services.AddTransient<frmLogin>();

            services.AddTransient<frmMainManagement>();
            services.AddTransient<frmProductManagement>();
            services.AddTransient<frmMaterialManagement>();
            services.AddTransient<frmCustomerManagement>();
            services.AddTransient<frmMainSale>();
            services.AddTransient<frmCreateOrderSaff>();
            services.AddTransient<frmOrderManagement>();
            services.AddTransient<frmSelectDrink>();


        }
    }
}
