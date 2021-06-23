using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagerMvc.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Employee ID isrequird")]
        public int EmployeeID {get;set;}

        [Column("FirstName")]
        [Display(Name ="Firts Name")]
        [Required(ErrorMessage = "First Name is requird")]
        [StringLength(20, ErrorMessage ="First Name must be less that 10 characters")]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is requird")]
        [StringLength(20, ErrorMessage = "Last Name must be less that 10 characters")]
        public string LastName { get; set; }

        [Column("Title")]
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is requird")]
        [StringLength(20, ErrorMessage = "Title must be less that 10 characters")]
        public string Title { get; set; }

        [Column("BirthDate")]
        [Display(Name = "Birt Date")]
        [Required(ErrorMessage = "Birt Date is requird")]
         public DateTime BirthDate { get; set; }

        [Column("HireDate")]
        [Display(Name = "Hire Date")]
        [Required(ErrorMessage = "Hire Date is requird")]
        public DateTime HireDate { get; set; }

        [Column("Country")]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is requird")]
        public string Country { get; set; }

        [Column("Notes")]
        [Display(Name = "Notes")]
        [Required(ErrorMessage = "Notes is requird")]
        public string Notes { get; set; }

    }
}
