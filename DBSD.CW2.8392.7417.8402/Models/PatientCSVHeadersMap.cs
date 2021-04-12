using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public sealed class PatientCSVHeadersMap : ClassMap<Patient>
    {
        public PatientCSVHeadersMap()
        {
            Map(m => m.Id).Index(0).Name("id");
            Map(m => m.FirstName).Index(1).Name("First Name");
            Map(m => m.LastName).Index(2).Name("Last Name");
            Map(m => m.DoB).Index(3).Name("Date of Birth");
            Map(m => m.Occupation).Index(4).Name("Occupation");
            Map(m => m.Gender).Index(5).Name("Gender");
            Map(m => m.Phone).Index(6).Name("Phone");
            Map(m => m.Address).Index(7).Name("Address");
            Map(m => m.Photo).Index(8).Name("Photo");
            Map(m => m.RegisteredDate).Index(9).Name("Registered Date");
            Map(m => m.EmergencyHospitalization).Index(10).Name("Emergency Hospitalization");
            Map(m => m.IsDischarged).Index(11).Name("Is Discharged");
            Map(m => m.DiagnoseName).Index(12).Name("Diagnose Name");
            Map(m => m.DoctorName).Index(13).Name("Doctor Name");
            Map(m => m.DepartmentName).Index(14).Name("Department Name");
            Map(m => m.NurseName).Index(15).Name("Nurse Name");
            Map(m => m.WardNo).Index(16).Name("Ward No");
        }
       
    }
}
