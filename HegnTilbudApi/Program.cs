using Microsoft.EntityFrameworkCore;
using HegnTilbudApi.Model;
using HegnTilbudApi.Data;

namespace HegnTilbudApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<HegnTilbudContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SurfAndTurfContext") ?? throw new InvalidOperationException("Connection string 'SurfAndTurfContext' not found.")));


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