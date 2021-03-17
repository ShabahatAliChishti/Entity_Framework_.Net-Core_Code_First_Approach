using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core_.Net_Core.Models
{
    public class Student
    {
        
        
        //primary key studentid by [Key] attribute
        [Key]
        //make studentid identity field agr ni krna tou none krden
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Column (TypeName ="nvarchar(250)")]
        [Display(Name = "Full Name:")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Mobile:")]
        public string Mobile { get; set; }
        [Column(TypeName = "datetime")]

        [Display(Name = "Date Of Birth:")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Salary { get; set; }
        [Column(TypeName = "nvarchar(max)")]

        [Display(Name = "Notes:")]
        //for generating automatically textarea
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        //[Column(TypeName = "nvarchar(50)")]

        //public string Test { get; set; }


    }
}
