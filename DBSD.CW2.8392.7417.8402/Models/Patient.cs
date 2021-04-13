using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public class Patient
    {
        // Some fields are not included such as ids
        // because they are considered as sensible data

        public int? Id { get; set; }

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

        [JsonConverter(typeof(JsonStringEnumConverter))]
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

        [DisplayName("Diagnose name")]
        public string DiagnoseName { get; set; }

        [DisplayName("Doctor")]

        public int? DoctorId { get; set; }

        [DisplayName("Doctor name")]
        public string DoctorName { get; set; }

        [DisplayName("Department")]
        public string DepartmentName { get; set; }

        [DisplayName("Ward")]
        public int? WardId { get; set; }

        [DisplayName("Ward number")]
        public string WardNo { get; set; }

        [DisplayName("Nurse name")]
        public string NurseName { get; set; }

        [DisplayName("Emergency Hospitalization")]
        public bool EmergencyHospitalization { get; set; }

        [DisplayName("Discharged")]
        public bool IsDischarged { get; set; }

        [XmlIgnore]
        public byte[] Photo { get; set; }

    }
}
[JsonConverter(typeof(StringEnumConverter))]
public enum Gender
{
    [EnumMember(Value = "Male")]

    Male,
    [EnumMember(Value = "Female")]
    Female
}
