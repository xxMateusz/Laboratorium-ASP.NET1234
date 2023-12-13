using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("employees")]
    public class EmployeeEntity
    {
        [Key]
        [Column("id")]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(11)]
        public string Pesel { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        public string Surname { get; set; }

        [Required]
        public int Position { get; set; }

        [Required]
        public int Department { get; set; }

        public DateTime? EmploymentDate { get; set; }

        public DateTime? SackingDate { get; set; }
    }
}
