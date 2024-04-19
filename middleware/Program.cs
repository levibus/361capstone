namespace _361capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapPost("/api/createaccount", (UserRegistration user) =>
            {
                // Here, you would typically add logic to validate the user input
                // and to save the user data to a database.
                if (string.IsNullOrEmpty(user.Email))
                {
                    return Results.BadRequest("Email is required");
                }
                // Assume account creation is successful
                return Results.Ok(new { Message = "Account created successfully!" });
            });

            app.MapRazorPages();

            app.Run();



        }
    }

    public class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
