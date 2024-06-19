using DynamicApplication.BL;
using DynamicApplication.Utilities;
using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cosmos DB config
SocketsHttpHandler socketsHttpHandler = new()
{
    PooledConnectionLifetime = TimeSpan.FromMinutes(5)
};
builder.Services.AddSingleton(socketsHttpHandler);
builder.Services.AddSingleton(ServiceProvider =>
{
    CosmosClientOptions options = new()
    {
        HttpClientFactory = () => new HttpClient(socketsHttpHandler, false),
        SerializerOptions = new CosmosSerializationOptions { PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase, IgnoreNullValues = true }
    };
    return new CosmosClient(builder.Configuration.GetConnectionString("CosmosDB"), options);
});

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AutoMapperProfile());
});
builder.Services.AddScoped<IFormService, FormService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
