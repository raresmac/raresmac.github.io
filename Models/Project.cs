namespace raresmac.github.io.Models
{
    public class Project
    {
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string GithubUrl { get; set; } = "";
        public string? ExternalUrl { get; set; } // New Property: Optional link to a live site
        public string? VideoId { get; set; } // For YouTube: "dQw4w9WgXcQ"
        public List<string> Tags { get; set; } = new();
    }
}