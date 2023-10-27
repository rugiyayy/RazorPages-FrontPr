namespace task1_RazorP_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();
            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseHsts();
            app.UseDefaultFiles();
            app.UseAuthorization();
            app.UseRouting();


            app.MapRazorPages();
            app.Run();











        }
    }
}