using Kiddo.Test.Dotnet.Repository;
using Kiddo.Test.Dotnet.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IClassRepository>(provider =>
{
    string classJsonFilePath = builder.Configuration.GetValue<string>("ClassJsonFilePath") ?? "";
    if (classJsonFilePath == null)
    {
        throw new InvalidOperationException("ClassJsonFilePath is null. Check your configuration.");
    }
    return new ClassRepository(classJsonFilePath);
});

builder.Services.AddScoped<IClassService, ClassService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

