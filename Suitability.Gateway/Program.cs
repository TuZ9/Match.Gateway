using Suitability.Gateway.Infrastructure.Extensions;
using Suitability.Gateway.Infrastructure.Ioc.Utils;
using Suitability.Gateway.Infrastructure.Static;

var builder = WebApplication.CreateBuilder(args);
SwaggerConfiguration.AddSwagger(builder.Services);
builder.Services.AddHttpClients();
builder.Services.AddMemoryCache();
RunTimeConfig.SetConfigs(builder.Configuration);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHealthChecks();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy("All", opt => opt
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed(hostname => true)));
builder.WebHost.UseKestrel(so =>
{
    so.Limits.KeepAliveTimeout = TimeSpan.FromSeconds(10000);
    so.Limits.MaxRequestBodySize = 52428800;
    so.Limits.MaxConcurrentConnections = 100;
    so.Limits.MaxConcurrentConnections = 100;
});

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.UseAuthentication();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors("All");
app.MapControllers();
app.Run();
