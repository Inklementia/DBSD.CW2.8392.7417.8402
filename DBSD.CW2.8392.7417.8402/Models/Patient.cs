using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public class Patient
    {
        public int? PatientId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName{ get; set; }

        [DisplayName("Date of Birth")]
        public DateTime? DoB { get; set; }

        public string Occupation { get; set; }

        public int Gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        [DisplayName("Registered Date")]
        public DateTime RegisteredDate { get; set; }

        [DisplayName("Diagnose")]
        public int? DiagnoseId { get; set; }

        [DisplayName("Doctor")]
        public int? DoctorId { get; set; }

        [DisplayName("Doctor Name")]
        public string DoctorName { get; set; }

        [DisplayName("Ward")]
        public int? WardId { get; set; }

        [DisplayName("Emergency Hospitalization")]
        public bool EmergencyHospitalization { get; set; }

        [DisplayName("Discharged")]
        public bool IsDischarged { get; set; }

        public byte[] Photo { get; set; }

    }
}
