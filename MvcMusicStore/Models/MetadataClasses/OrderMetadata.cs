using DTClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    [ModelMetadataType(typeof(OrderMetadata))]
    public partial class Order : IValidatableObject
    {
        MvcMusicStoreContext _context = new MvcMusicStoreContext();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //FirstName= XXValidations.Capitalise(FirstName);
            LastName= LastName.Trim();
            if (City != null) City.Trim();

            var province = _context.Province.Find(ProvinceCode);
            if (province == null)
                yield return new ValidationResult(
                    "province code is not on file",
                    new[] { "ProvinceCode" });
            else
            {
                if (CountryCode != province.CountryCode)
                    yield return new ValidationResult(
                        "province code is not in that country",
                    new[] { "ProvinceCode", "CountryCode" });
            }





            yield return ValidationResult.Success;
        }
    }
    public class OrderMetadata
    {
        public int OrderId { get; set; }

        [Display(Name ="Date Ordered")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:d MMM yyyy}")]
        //[Remote("OrderDateNotInFuture", "Remotes")]
        [DateNotInFuture]
        public DateTime OrderDate { get; set; }

        [Display(Name ="Full Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [WordCount(5)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [WordCountAttribute(5, 2)]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Province")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z]$")]
        public string ProvinceCode { get; set; }

        [Display(Name = "Postal Code")]
        [Remote("PostalCodeValidation", "Remotes")]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z]$")]
        public string CountryCode { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "EMail")]
        public string Email { get; set; }

        [Display(Name = "Order Total")]
        public double Total { get; set; }
    }
}
