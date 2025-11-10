using Microsoft.EntityFrameworkCore;

namespace Movies.API.Data.Extensions;

public static class DatabaseExtensions
{
    public static async Task InitialiseDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        
        var context = scope.ServiceProvider.GetRequiredService<MoviesAPIContext>();

        context.Database.MigrateAsync().GetAwaiter().GetResult();

        await SeedAsync(context);
    }

    private static async Task SeedAsync(MoviesAPIContext context)
    {
        await SeedMovieAsync(context);
    }

    private static async Task SeedMovieAsync(MoviesAPIContext context)
    {
        if (!await context.Movies.AnyAsync())
        {
            await context.Movies.AddRangeAsync(InitialData.Movies);
            await context.SaveChangesAsync();
        }
    }
}
