using DataAccessLayer;
using Domain.Manager;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Register UserManager with its dependencies

builder.Services.AddScoped<TicketManager>();
builder.Services.AddScoped<UserDB>();

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.UseSession();

app.MapRazorPages();

app.Run();
