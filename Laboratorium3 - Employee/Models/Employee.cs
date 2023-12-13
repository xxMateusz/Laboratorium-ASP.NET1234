using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3___Employee.Models
{
    public class Employee
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "PESEL is required!")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "PESEL must contain 11 characters!")]
        public string Pesel { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "Too long name, max 50 characters are allowed!")]
        public string Name { get; set; }

        [StringLength(maximumLength: 80, ErrorMessage = "Too long surname, max 80 characters are allowed!")]
        public string Surname { get; set; }

        public Positions Position { get; set; }

        public Departments Department { get; set; }

        [Display(Name = "Employment date")]
        public DateTime? EmploymentDate { get; set; }

        [Display(Name = "Sacking date")]
        public DateTime? SackingDate { get; set; }
    }
}
