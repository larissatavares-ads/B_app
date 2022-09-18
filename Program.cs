using B_app.Core.Interfaces.Adapter.Sql;
using B_app.Core.Settings;
using B_app.Domain.Application.Services;
using B_app.Domain.Core.Interfaces.Application.Services;
using B_app.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conexao = builder.Configuration.GetSection("ConnectionStrings").GetSection("mssql").Get<ConnectionStringSettings>();
builder.Services.AddSingleton(conexao);

builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


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
app.MapControllers();

app.Run();
