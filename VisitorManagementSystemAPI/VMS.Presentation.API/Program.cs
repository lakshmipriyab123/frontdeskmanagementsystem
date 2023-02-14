using Microsoft.EntityFrameworkCore;
using VMS.Core.Application.Interface;
using VMS.Core.Domain.Models.EmailService;
using VMS.Infrastructure.VMS.Infrastructure.Repository;
using VMS.Infrastructure.VMS.Infrastructure.Repository.Interface;
using VMS.Infrastructure.VMS.Infrastructure.Services;
using VMS.Infrastructure.VMS.Infrastructure.Services.AdminService;
using VMS.Infrastructure.VMS.Infrastructure.Services.VisitorComponent;
using VMS.Infrastructure.VMS.Infrastructure.Services.VisitorService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CatalogDBContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnecton")));
builder.Services.AddScoped<IVisitorForm, VisitorForm>();
builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IAdminDao, AdminDao>();
builder.Services.AddScoped<IVisitorDao, VisitorDao>();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
