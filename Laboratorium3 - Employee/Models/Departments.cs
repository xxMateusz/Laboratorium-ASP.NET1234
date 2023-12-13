using System.ComponentModel.DataAnnotations;

namespace Laboratorium3___Employee.Models
{
    public enum Positions
    {
        Manager,
        [Display(Name="Front-end Developer")]FrontEndDeveloper,
        [Display(Name="Back-end Developer")]BackEndDeveloper,
        [Display(Name="Full-stack Developer")]FullStackDeveloper,
    }
}
