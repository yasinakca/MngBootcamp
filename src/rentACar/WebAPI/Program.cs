using Application;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Mailing;
using Core.Mailing.MailKitImplementations;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddSingleton<IMailService, MailKitMailService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(b =>
{
    b.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.ConfigureCustomExceptionMiddleware();
app.UseAuthorization();

app.MapControllers();
app.UseCors();

app.Run();
