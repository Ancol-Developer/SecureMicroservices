using Movies.API.Model;

namespace Movies.API.Data.Extensions;

internal class InitialData
{
    public static IEnumerable<Movie> Movies =>
        new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16), Ower = "Christopher Nolan" },
                new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18), Ower = "Christopher Nolan" },
                new Movie { Id = 3, Title = "Interstellar", Genre = "Sci-Fi", ReleaseDate = new DateTime(2014, 11, 7), Ower = "Christopher Nolan" },
                new Movie { Id = 4, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseDate = new DateTime(1994, 9, 23), Ower = "Frank Darabont" },
                new Movie { Id = 5, Title = "Pulp Fiction", Genre = "Crime", ReleaseDate = new DateTime(1994, 10, 14), Ower = "Quentin Tarantino" },
                new Movie { Id = 6, Title = "The Matrix", Genre = "Sci-Fi", ReleaseDate = new DateTime(1999, 3, 31), Ower = "The Wachowskis" },
                new Movie { Id = 7, Title = "Fight Club", Genre = "Drama", ReleaseDate = new DateTime(1999, 10, 15), Ower = "David Fincher" },
                new Movie { Id = 8, Title = "Forrest Gump", Genre = "Drama", ReleaseDate = new DateTime(1994, 7, 6), Ower = "Robert Zemeckis" },
                new Movie { Id = 9, Title = "Gladiator", Genre = "Action", ReleaseDate = new DateTime(2000, 5, 5), Ower = "Ridley Scott" },
                new Movie { Id = 10, Title = "The Godfather", Genre = "Crime", ReleaseDate = new DateTime(1972, 3, 24), Ower = "Francis Ford Coppola" }
        };
}
