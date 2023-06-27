using MongoDB.Driver.Linq;
using MongoDB.Driver;
using ApiSirene.DataAccess.Data;
using ApiSirene.Logic.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.Configure<SireneDataCollection>(builder.Configuration.GetSection("LinkCs"));

var dbSettings = builder.Configuration.GetSection("LinkCs").Get<SireneDataCollection>();

builder.Services.AddSingleton<IMongoClient>(_ =>
{
    MongoClientSettings mongoSettings = MongoClientSettings.FromConnectionString(dbSettings.ConnectionString);
    mongoSettings.LinqProvider = LinqProvider.V3;

    return new MongoClient(mongoSettings);
});

builder.Services.AddScoped<IMongoDatabase>(x =>
{
    var client = x.GetRequiredService<IMongoClient>();
    return client.GetDatabase(dbSettings.DatabaseName);
});





builder.Services.AddScoped<IrecupRepositorie, RecupRepositorie>();







// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
