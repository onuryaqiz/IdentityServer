﻿using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>

opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")

));
builder.Services.AddIdentity<AppUser,IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseDeveloperExceptionPage();
app.UseStatusCodePages(); // Hatanın nerede olduğunu gösteren sayfa gösteriyor. 
app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseMvcWithDefaultRoute(); // Arka planda Controller/Action/{id} gibi ekler. 

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
