using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("DoctorSpecialization")]
    public class DoctorSpecialization
    {
        [Key]
        public int DocSpecId { get; set; }
        public string  DocSpecialization { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
