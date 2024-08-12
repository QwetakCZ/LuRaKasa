
using Microsoft.EntityFrameworkCore;
using WebAPILuRaKasa.Controllers;
using WebAPILuRaKasa.Data;

namespace WebAPILuRaKasa
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            //Pridani konfigurace pro pripojeni k DB

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                                    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
                                                        options.UseSqlServer(connectionString));


            builder.Services.AddTransient<ApplicationDBContext>();
            builder.Services.AddTransient<UserController>();
            // Add services to the container.

            builder.Services.AddControllers();
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
        }
    }
}
