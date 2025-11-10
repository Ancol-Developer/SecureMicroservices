namespace Movies.API.Model;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Genre { get; set; } = default!;
    public DateTime ReleaseDate { get; set; }
    public string Ower { get; set; } = default!;
}
