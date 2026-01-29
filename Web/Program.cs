using Core_.Interfaces;
using Core_.Services;
using Infrastructure.Data;
using Infrastructure.Providers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//data
builder.Services.AddSingleton<INaasRepository, NaasRepository>();

//providers
builder.Services.AddSingleton<IGetNaasDataProvider, GetNaasDataProvider>();

//services
builder.Services.AddSingleton<IHistoryService, HistoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
