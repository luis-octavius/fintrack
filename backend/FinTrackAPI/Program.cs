using FinTrackAPI.Config;

namespace FinTrackAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

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
