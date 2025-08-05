using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CSE325_team.Components;
using CSE325_team.Components.Account;
using CSE325_team.Data;
using CSE325_team.Models;
using CSE325_team.Services; // Add this if BookingState is in the State namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers();
    
builder.Services.AddHttpClient();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
// var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// if (builder.Environment.IsDevelopment())
// {
//     builder.Services.AddDbContext<ApplicationDbContext>(options =>
//         options.UseSqlite(connectionString)); // for local dev
// }
// else
// {
//     builder.Services.AddDbContext<ApplicationDbContext>(options =>
//         options.UseSqlServer(connectionString)); // for Azure SQL
// }


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    // .AddSignInManager() //can remove when using AddIdentity
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddScoped<BookingState>();

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

app.UseStaticFiles();
app.UseAntiforgery();

// Initialize the database
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    //Seeding Identity roles/users
    var services = scope.ServiceProvider;
   
    // Seeding data via ApplicationDbContext
    var db = services.GetRequiredService<ApplicationDbContext>();
    await db.Database.MigrateAsync();
    await CSE325_team.Data.SeedUser.InitializeAsync(services);
    await CSE325_team.Data.SeedVehicle.InitializeAsync(db);   
    await CSE325_team.Data.SeedBooking.InitializeAsync(db);
    await CSE325_team.Data.SeedPayment.InitializeAsync(db);
}


app.MapControllers();

app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
