
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
/// Identity Layer Configurations
builder.Services.LoadIdentityConf();
builder.Services.LoadIdentityServices();
builder.Services.LoadJwtConf(builder.Configuration);
/// Infrastructure Layer Configurations
builder.Services.LoadInfrastructureConf(builder.Configuration);
/// Application Layer Configuration
builder.Services.LoadApplicationServicesConf();
/// Persistence Layer Configuration
builder.Services.LoadPersistenceServicesConf();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

await SeedData.SeedAsync(app);


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseCookiePolicy();
app.MapControllers();


app.Run();
