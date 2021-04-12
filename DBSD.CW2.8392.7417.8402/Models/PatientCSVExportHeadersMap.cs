using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public sealed class PatientCSVExportHeadersMap : ClassMap<Patient>
    {
        public PatientCSVExportHeadersMap()
        {
            Map(m => m.Id).Index(0).Name("Id");
            Map(m => m.FirstName).Index(1).Name("FirstName");
            Map(m => m.LastName).Index(2).Name("LastName");
            Map(m => m.DoB).Index(3).Name("DoB");
            Map(m => m.Occupation).Index(4).Name("Occupation");
            Map(m => m.Gender).Index(5).Name("Gender");
            Map(m => m.Phone).Index(6).Name("Phone");
            Map(m => m.Address).Index(7).Name("Address");
            Map(m => m.RegisteredDate).Index(8).Name("RegisteredDate");
            Map(m => m.EmergencyHospitalization).Index(9).Name("EmergencyHospitalization");
            Map(m => m.IsDischarged).Index(10).Name("IsDischarged");
            Map(m => m.DiagnoseName).Index(11).Name("DiagnoseName");
            Map(m => m.DoctorName).Index(12).Name("DoctorName");
            Map(m => m.DepartmentName).Index(13).Name("DepartmentName");
            Map(m => m.NurseName).Index(14).Name("NurseName");
            Map(m => m.WardNo).Index(15).Name("WardNo");
        }
       
    }
}
