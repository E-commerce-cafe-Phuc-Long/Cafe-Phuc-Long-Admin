using BLL.Services;
using BLL.Services.Category;
using BLL.Services.Customer;
using BLL.Services.GoodsReceipt;
using BLL.Services.GoodsReceiptDetails;
using BLL.Services.Dosage;
using BLL.Services.Material;
using BLL.Services.Method;
using BLL.Services.Order;
using BLL.Services.OrderDetail;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Recipe_material;
using BLL.Services.Role;
using BLL.Services.Size;
using BLL.Services.Staff;
using BLL.Services.Supplier;
using DAL.Repositories.Category;
using DAL.Repositories.Category.GoodsReceipt;
using DAL.Repositories.Customer;
using DAL.Repositories.GoodsReceiptDetails;
using DAL.Repositories.Dosage;
using DAL.Repositories.Material;
using DAL.Repositories.Method;
using DAL.Repositories.Order;
using DAL.Repositories.OrderDetail;
using DAL.Repositories.Product;
using DAL.Repositories.ProductDetail;
using DAL.Repositories.Recipe;
using DAL.Repositories.Size;
using DAL.Repositories.Recipe_material;
using DAL.Repositories.Role;
using DAL.Repositories.Staff;
using DAL.Repositories.Supplier;
using GUI.Forms;
using GUI.Forms.Manager;
using GUI.Forms.Manager.GoodsReceipt;
using GUI.Forms.Manager.Staff;
using GUI.Forms.Manager.Customer;
using GUI.Forms.Manager.Role;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using GUI.Forms.Manager.Supplier;
using BLL.Services.Auth;
using DAL.Repositories.Auth;
using DTO;
using GUI.Forms.Manager.Report;
using DAL.Repositories.Report;
using BLL.Services.Report;
using DAL.Repositories.Account;
using BLL.Services.Account;
using GUI.Forms.Manager.Account;
using BLL.Services.StatusOrder;
using DAL.Repositories.StatusOrder;

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
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddTransient<IGoodsReceiptRepository, GoodsReceiptRepository>();
            services.AddTransient<IGoodsReceiptDetailsRepository, GoodsReceiptDetailsRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IDosageRepository, DosageRepository>(); 
            services.AddTransient<IMethodRepository, MethodRepository>();
            services.AddTransient<IReportRepository, ReportRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IStatusOrderRepository, StatusOrderRepository>();


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
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ISupplierService, SupplierService>();
            services.AddTransient<IGoodsReceiptService, GoodsReceiptService>();
            services.AddTransient<IGoodsReceiptDetailsService, GoodsReceiptDetailsService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IDosageService, DosageService>();
            services.AddTransient<IMethodService, MethodService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IStatusOrderService, StatusOrderService>();

        }
        public static void AddForms(this IServiceCollection services)
        {
            // Đăng ký form frmLogin vào DI container
            services.AddTransient<frmLogin>();

            services.AddTransient<frmMainManagement>();
            services.AddTransient<frmProductManagement>();
            services.AddTransient<frmMaterialManagement>();
            services.AddTransient<FrmCustomerManagement>();
            services.AddTransient<frmRoleManagement>();
            services.AddTransient<frmMainSale>();
            services.AddTransient<frmCreateOrderSaff>();
            services.AddTransient<frmOrderManagement>();
            services.AddTransient<frmStaffManagement>();
            services.AddTransient<frmSupplierManagement>();
            services.AddTransient<frmGoodsReceiptManagement>();
            services.AddTransient<frmSelectDrink>();
            services.AddTransient<frmCheckout>();
            services.AddTransient<frmReportManagement>();
            services.AddTransient<frmAccountManagement>();



        }


    }
}
