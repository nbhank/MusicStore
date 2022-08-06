using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcMusicStore.Controllers;

namespace MvcMusicStore.Models
{
    public partial class Artist : IValidatableObject
    {
        public Artist()
        {
            Album = new HashSet<Album>();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {            
            if (Name.ToLower() == "bob")
                yield return new ValidationResult(
                    LocalizationController.StringLocalizer["serving everyone but {0}", Name],
                    new[] { "Name" });
        }

        public int ArtistId { get; set; }
        [Required(ErrorMessage = "{0} cannot be empty or just spaces")]
        [Display(Name="Name")]
        public string Name { get; set; }

        public ICollection<Album> Album { get; set; }
    }
}
