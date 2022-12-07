using Basket.API.GrpcServivices;
using Basket.API.Repositories;
using Discount.gRPC.Protos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetValue<string>("CacheSettings:ConnectionString");

});
builder.Services.AddScoped<IBasketRepository, BasketRepository>();
Console.WriteLine(builder.Configuration["GrpcSettings:DiscountUrl"]);
builder.Services.AddGrpcClient<DiscountProtoServices.DiscountProtoServicesClient>(o =>
{
    o.Address = new Uri(builder.Configuration["GrpcSettings:DiscountUrl"]);
    //o.Address = new Uri("http://localhost:5003");
});
builder.Services.AddScoped<DiscountGrpcService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
