using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public class PatientCreateViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DoB { get; set; }

        public string Occupation { get; set; }

        public Gender Gender { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [DisplayName("Registered Date")]
        [DataType(DataType.Date)]
        public DateTime RegisteredDate { get; set; }

        [DisplayName("Diagnose")]
        public int? DiagnoseId { get; set; }

        [DisplayName("Doctor")]
        public int? DoctorId { get; set; }

        [DisplayName("Ward")]
        public int? WardId { get; set; }

        [DisplayName("Emergency Hospitalization")]
        public bool EmergencyHospitalization { get; set; }

        [DisplayName("Discharged")]
        public bool IsDischarged { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
    }
}
