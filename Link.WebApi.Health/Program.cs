using DataAccess.DBContext;
using Link.DataAccess.Core.Base;
using Link.DataAccess.Core.UnitOfWork;
using Link.Utilitty;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


#region Constants 

Constants.ConnectionString = builder.Configuration.GetConnectionString("HealthDB");
Constants.Swagger = builder.Configuration.GetValue<string>("Swagger");

#endregion

#region Configuration Database

var cs = builder.Configuration.GetConnectionString("HealthDB");
Console.WriteLine("===== DB CONNECTION STRING =====");
Console.WriteLine(cs);
Console.WriteLine("================================");

builder.Services.AddDbContext<HealthDBContext>(options =>
{
    options.UseSqlServer(Constants.ConnectionString);
});


#endregion


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddCors();

builder.Services.AddSwaggerGen(options =>
{
    // fisrt we can change the swagger UI that take name(string) the second documantaion info 
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "TestApi", //change the title
        Description = "My first api",
        TermsOfService = new Uri("https://www.google.com"),// terms of service
        Contact = new OpenApiContact
        {               //contact
            Name = "Muhammad",
            Email = "test@domain.com",
            Url = new Uri("https://www.google.com")
        },
        License = new OpenApiLicense
        {              //License
            Name = "My license",
            Url = new Uri("https://www.google.com")
        },

    });
});


builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient <IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));


app.UseAuthorization();

app.MapControllers();

app.Run();
