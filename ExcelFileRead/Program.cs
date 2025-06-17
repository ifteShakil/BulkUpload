using BulkUpload.Components;
using Microsoft.EntityFrameworkCore;
using BulkUpload.DataModel;
using BulkUpload.Repository.Interface;
using BulkUpload.Repository.Services;
using Radzen;
using static BulkUpload.Components.Pages.Authentication.Login;
using Microsoft.AspNetCore.Components.Authorization;
using BulkUpload.DataModel.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using BulkUpload.Repository.UserHelper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddRadzenComponents();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<ProtectedLocalStorage>();

builder.Services.AddSingleton<UserSession>();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

builder.Services.AddTransient<UserAccountService>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddTransient<IStockReceiveTempService, StockReceiveTempService>();
builder.Services.AddTransient<IStockSalesTempService, StockSalesTempService>();

builder.Services.AddTransient<IStockPort, StockPortService>();
builder.Services.AddTransient<IStockPoType, StockPoTypeService>();
builder.Services.AddTransient<IProduct, ProductService>();
builder.Services.AddTransient<IProductGroup, ProductGroupService>();
builder.Services.AddTransient<ISupplier, SupplierService>();
builder.Services.AddTransient<IStore, StoreService>();
builder.Services.AddTransient<IStockVATHSCode, StockVATHSCodeService>();
builder.Services.AddTransient<IUnit, UnitService>();
builder.Services.AddTransient<ICustomer, CustomerService>();

builder.Services.AddTransient<IStockVatPurchaseNature, StockVatPurchaseNatureService>();
builder.Services.AddTransient<IStockVATSalesNature, SalesNatureService>();

builder.Services.AddTransient<IDeliveryPoint, DeliveryPointService>();
builder.Services.AddTransient<IVehicleType, VehicleTypeService>();
builder.Services.AddTransient<ITransactionID, TransactionIDService>();

builder.Services.AddTransient<IStockSummary, StockSummaryService>();

builder.Services.AddServerSideBlazor().AddCircuitOptions(options =>
{
    options.DetailedErrors = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
