using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public class PatientFilterViewModel
    {
        [DisplayName("Full name")]
        public string Name { get; set; }

        public string Address { get; set; }

        [DisplayName("Registered Date")]
        [DataType(DataType.Date)]
        public DateTime? RegisteredDate { get; set; }

        [DisplayName("Diagnose Name")]
        public string DiagnoseName { get; set; }

        [DisplayName("Doctor Name")]
        public string DoctorName { get; set; }

        public int CurrentPage { get; set; } = 1;

        [DisplayName("Sort desceding")]
        public bool SortDesc { get; set; }

        [DisplayName("Sort by")]
        public SortColumn SortColumn { get; set; }

        public IPagedList<Patient> Patients;
    }
    public enum SortColumn
    {
        [Display(Name = "Patient last name")]
        LastName,
        [Display(Name = "Ward number")]
        WardNo,
        [Display(Name = "Doctor last name")]
        DoctorName,
        [Display(Name = "Nurse last name")]
        NurseName,
        [Display(Name = "Date registered")]
        RegisteredDate
    }
}
