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
            Map(m => m.Id).Name("Id");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.DoB).Name("DoB");
            Map(m => m.Occupation).Name("Occupation");
            Map(m => m.Gender).Index(0).Name("Gender");
            Map(m => m.Phone).Name("Phone");
            Map(m => m.Address).Name("Address");
            Map(m => m.RegisteredDate).Name("RegisteredDate");
            Map(m => m.DiagnoseId).Name("DiagnoseId");
            Map(m => m.DiagnoseName).Name("DiagnoseName");
            Map(m => m.DoctorId).Name("DoctorId");
            Map(m => m.DoctorName).Name("DoctorName");
            Map(m => m.DepartmentName).Name("DepartmentName");
            Map(m => m.WardId).Name("WardId");
            Map(m => m.WardNo).Name("WardNo");
            Map(m => m.NurseName).Name("NurseName");
            Map(m => m.EmergencyHospitalization).Name("EmergencyHospitalization");
            Map(m => m.IsDischarged).Name("IsDischarged");

        }

    }
}
