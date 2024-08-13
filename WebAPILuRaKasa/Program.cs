
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
            // Pøidání konfigurace pro pøipojení k DB
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
