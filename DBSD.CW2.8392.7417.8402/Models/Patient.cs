using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    [DataContract]
    public class Patient
    {
        // Some fields are not included such as ids
        // because they are considered as sensible data

        public int? Id { get; set; }

        [DataMember]
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DoB { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }

        [DataMember]
        [Required]
        public string Phone { get; set; }

        [DataMember]
        [Required]
        public string Address { get; set; }

        [DataMember]
        [DisplayName("Registered Date")]
        [DataType(DataType.Date)]
        public DateTime RegisteredDate { get; set; }

        [DisplayName("Diagnose")]
        public int? DiagnoseId { get; set; }

        [DisplayName("Doctor")]
        public int? DoctorId { get; set; }

        [DisplayName("Ward")]
        public int? WardId { get; set; }
        [DataMember]
        [DisplayName("Emergency Hospitalization")]
        public bool EmergencyHospitalization { get; set; }
        [DataMember]
        [DisplayName("Discharged")]
        public bool IsDischarged { get; set; }

        public byte[] Photo { get; set; }

        [DataMember]
        [DisplayName("Diagnose name")]
        public string DiagnoseName { get; set; }

        [DataMember]
        [DisplayName("Doctor name")]
        public string DoctorName { get; set; }

        [DataMember]
        [DisplayName("Department")]
        public string DepartmentName { get; set; }

        [DataMember]
        [DisplayName("Ward number")]
        public string WardNo { get; set; }

        [DataMember]
        [DisplayName("Nurse name")]
        public string NurseName { get; set; }
    }
}
public enum Gender
{
    [EnumMember(Value = "Male")]
    Male,
    [EnumMember(Value = "Female")]
    Female
}
