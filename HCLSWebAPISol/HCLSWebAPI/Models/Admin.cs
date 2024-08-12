using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Please Enter name ...!")]
        [StringLength(15, ErrorMessage = "Please Enter Upto 15 Chars Only ...!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Gender ...!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter  Email address ...!")]
       // [RegularExpression("(([^<>()\\[\\]\\\\.,;:\\s@\"]+(\\.[^<>()\\[\\]\\\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))", ErrorMessage = " Please enter proper email address  ...!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter  Password ...!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter  Address ...!")]
        public string Address { get; set; }
        public bool Active { get; set; }

        [ForeignKey("AdminType")]

        [Required(ErrorMessage = "Please Select AdmintypeId ...!")]
        public int AdminTypeId { get; set; }
        public AdminType AdminType { get; set; }
    }
}
