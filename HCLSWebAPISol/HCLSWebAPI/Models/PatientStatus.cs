using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("PatientStatus")]
    public class PatientStatus
    {
        [Key]
        public int StatID { get; set; }
        public string StatName { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}
