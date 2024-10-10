using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string PName { get; set; }
        public string  Gender { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CameForDiagnosit {  get; set; }
        public DateTime VisitedDate { get; set; } 
        public DateTime UpCmngVisitDate { get; set; }
        public decimal BillAmount { get; set; }
        public string MedicalDiscription { get; set; }
        public bool Active { get; set; }

        [ForeignKey("DoctorSpecialization")]
        public int DocSpecId { get; set; }

        [ForeignKey("Doctor")]
        public int DocId { get; set; }
        [ForeignKey("Lab")]
        public int LabId { get; set; }
        [ForeignKey("Helper")]
        public int HelpId { get; set; }
        [ForeignKey("Receptionist")]
        public int RecpId { get; set; }

        [ForeignKey("PatientStatus")]
        public int StatId { get; set; }
 
        public Doctor Doctor { get; set; }
        public DoctorSpecialization DoctorSpecialization { get; set; }
        public Lab Lab { get; set; }
        public Helper Helper { get; set; }
        public Receptionist Receptionist { get; set; }  
        public PatientStatus PatientStatus { get; set; }





    }
}
