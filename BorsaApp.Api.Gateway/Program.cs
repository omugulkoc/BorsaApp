namespace BorsaApp.Api.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
             

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

          

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
