using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Lab")]
    public class Lab
    {
        [Key]
        public int LabId { get; set; }

        [Required(ErrorMessage = "Please Enter name ...!")]
        [StringLength(15, ErrorMessage = "Please Enter Upto 15 Chars Only ...!")]
        public string LabName { get; set; }

        [Required(ErrorMessage = "Please Enter DOB ...!")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please Enter DOJ ...!")]
        public DateTime DOJ { get; set; }

        [Required(ErrorMessage = "Please Enter Phone ...!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Email ...!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password ...!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Salary ...!")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please Enter Address ...!")]
        public string Address { get; set; }
        public bool Active { get; set; }
        public bool Logged { get; set; }

        [ForeignKey("Department")]

        [Required(ErrorMessage = "Please Enter DeptNpo ...!")]
        public int DeptNo { get; set; }
        public Department Department { get; set; }
    }
}
