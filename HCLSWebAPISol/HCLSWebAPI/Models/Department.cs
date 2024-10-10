using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Department")]
    
    public class Department
    {
        [Key]
        public int  DeptNo { get; set; }
        public string Dname { get; set; }
        public ICollection<Receptionist> Receptionists { get; set; }
        public ICollection<Helper> Helpers { get; set; }
        public ICollection<Lab> Labs { get; set; }
        public ICollection<Doctor> Doctor { get; set; }
    }
}
