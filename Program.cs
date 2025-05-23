using LegoCollectionUI.Components;
using LegoCollectionUI.Components.Account;
using LegoCollectionUI.Data;
using LegoCollectionUI.Clients;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var legoCollectionApiUrl = builder.Configuration["LegoCollectionApiUrl"] ?? throw new Exception("LegoCollectionApiUrl is not set");

builder.Services.AddHttpClient<OwnedClient>(client => client.BaseAddress = new Uri(legoCollectionApiUrl));
builder.Services.AddHttpClient<ColorsClient>(client => client.BaseAddress = new Uri(legoCollectionApiUrl));
builder.Services.AddHttpClient<FullBrickReportClient>(client => client.BaseAddress = new Uri(legoCollectionApiUrl));
builder.Services.AddHttpClient<LocationClient>(client => client.BaseAddress = new Uri(legoCollectionApiUrl));
builder.Services.AddHttpClient<BricksClient>(client => client.BaseAddress = new Uri(legoCollectionApiUrl));
builder.Services.AddHttpClient<CategoriesClient>(client => client.BaseAddress = new Uri(legoCollectionApiUrl));

//Add Clients to IServiceProviders for lifetime of app
//builder.Services.AddSingleton<OwnedClient>();
//builder.Services.AddSingleton<ColorsClient>();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
