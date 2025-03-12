using System.ComponentModel.DataAnnotations;



namespace BlazorApp9.Client.Models
{
    public class Episode
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Air date is required")]
        public DateTime AirDate { get; set; }
        [Required(ErrorMessage = "Episode code is required")]
        public string EpisodeCode { get; set; }

        [Required(ErrorMessage = "Characters is required")]

        public List<string> Characters { get; set; }
        [Required(ErrorMessage = "Url is required")]
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
