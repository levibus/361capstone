namespace _361capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(
                    name: "_MyAllowSubdomainPolicy",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    }
                );
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddControllers().AddNewtonsoftJson();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseCors("_MyAllowSubdomainPolicy");
            app.UseAuthorization();
            app.MapControllers();
            app.Run();

        }
    }
}



