using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }

        [Required(ErrorMessage = "You must specify the name!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Too long name, max 50 chars")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public string? Phone { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime? Birth { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        public int? OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> OrganizationList { get; set; }
    }
}
