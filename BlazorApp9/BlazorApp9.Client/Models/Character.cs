using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace BlazorApp9.Client.Models
{
    public class Character
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]


        public string Name { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Species is required")]
        public string Species { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        public Origin Origin { get; set; }
        public Location Location { get; set; }
        public string Image { get; set; }
        public List<string> Episode { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
