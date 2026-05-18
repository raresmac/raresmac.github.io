namespace raresmac.github.io.Models
{
    public class Certification
    {
        public string Title { get; set; } = "";
        public string Organization { get; set; } = "";
        public string DateString { get; set; } = "";
        public string? CredentialUrl { get; set; }
        public List<string> Skills { get; set; } = new();
    }
}
