using api.tork.challenge.application.DependencyInjection;
using api.tork.challenge.DbRepository;
using api.tork.challenge.DbRepository.DependencyInjection;
using api.tork.challenge.DbRepository.V1.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

new InitialDatabase();

builder.Services.AddDbRepositoryAdapter();
builder.Services.AddApplication();
builder.Services.AddAutoMapper(typeof(DbRepositoryAdapterMapperProfile));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

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

app.UseCors();

app.Run();
