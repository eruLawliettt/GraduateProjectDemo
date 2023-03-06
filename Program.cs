using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GraduateProjectDemo.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GraduateProjectDemoIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'GraduateProjectDemoIdentityDbContextConnection' not found.");

builder.Services.AddDbContext<GraduateProjectDemoIdentityDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<GraduateProjectDemoIdentityDbContext>();

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
