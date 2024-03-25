using api.tork.challenge.application.DependencyInjection;
using api.tork.challenge.DbRepository;
using api.tork.challenge.DbRepository.DependencyInjection;
using api.tork.challenge.DbRepository.V1.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

new InitialDatabase();

builder.Services.AddDbRepositoryAdapter();
builder.Services.AddApplication();
builder.Services.AddAutoMapper(typeof(DbRepositoryAdapterMapperProfile));

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
