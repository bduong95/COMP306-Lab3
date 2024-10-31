namespace MovieStreamingApp.Models
{
    public class Movie
    {
        public int Id { get; set; }                // Unique identifier for each movie
        public string Title { get; set; }          // Title of the movie
        public string Genre { get; set; }          // Genre of the movie
        public string Director { get; set; }       // Director’s name
        public DateTime ReleaseDate { get; set; }  // Release date
        public double Rating { get; set; }         // Rating (e.g., 8.5)
        public int OwnerId { get; set; }
    }
}
