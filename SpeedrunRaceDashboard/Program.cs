using Microsoft.EntityFrameworkCore;
using SpeedrunRaceDashboard.Components;
using SpeedrunRaceDashboard.Models;

namespace SpeedrunRaceDashboard;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddDbContextFactory<RaceDbContext>(options =>
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "race.db");
            options.UseSqlite($"Data Source={dbPath};Mode=ReadWriteCreate;Cache=Shared");

        });

        


        var app = builder.Build();
        using (var scope = app.Services.CreateScope())
        {
            var dbFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<RaceDbContext>>();
            using var db = dbFactory.CreateDbContext();

            db.Database.Migrate();

            var settingsb = db.StreamSettings.FirstOrDefault();

            if (settingsb == null)
            {
                settingsb = new StreamSettings();

                //default load the colours with white and black
                settingsb.HeaderTextColour = "#FFFFFF";
                settingsb.BackgroundColour = "#000000";
                settingsb.MainBackgroundColour = "#000000";
                settingsb.SidebarTextColour = "#FFFFFF";
                settingsb.SidebarBackgroundColour = "#000000";
                settingsb.AccentColour = "#FF0000"; // Default accent colour
                settingsb.FontFamily = "Roboto, sans-serif"; // Default font family
                settingsb.GoogleFontUrl = "https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap";



                db.StreamSettings.Add(settingsb);

            }

                var defaultProfile = db.StreamProfiles.FirstOrDefault(p => p.TwitchUsername == "unassigned");
            if (defaultProfile == null)
            {
                defaultProfile = new StreamProfile
                {
                    TwitchUsername = "unassigned",
                    TwitchDisplayName = "Unassigned",
                    UserDisplayName = "N/A",
                    GameName = "N/A",
                    TeamColour = "#CCCCCC",
                    CompletedTime = "",
                    PersonalBest = ""
                };
                db.StreamProfiles.Add(defaultProfile);
                db.SaveChanges();
            }

            var existingSlots = db.StreamSlots.ToList();
            for (int i = 1; i <= 10; i++)
            {
                if (!existingSlots.Any(s => s.ViewOrder == i))
                {
                    db.StreamSlots.Add(new StreamSlot
                    {
                        ViewOrder = i,
                        ProfileId = defaultProfile.Id,
                        TeamColour = "#FFFFFF"
                    });
                }
            }

            db.SaveChanges();

            db.Database.ExecuteSqlRaw("PRAGMA journal_mode=WAL;");
        }

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
