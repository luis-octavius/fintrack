using FinTrackAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FinTrackAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContext<FinTrackDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=POSTGRES_FINTRACK;Username=postgres;Password=mysecret",
                npgsqlOptions => npgsqlOptions.MigrationsHistoryTable("__EFMigrationsHistory", "fintrack")
            ));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
            }
            app.UseRouting();
            app.MapControllers();

            app.Run();
        }
    }
}
