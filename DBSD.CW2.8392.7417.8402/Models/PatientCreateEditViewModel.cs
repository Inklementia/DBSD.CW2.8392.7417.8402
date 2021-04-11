using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public class PatientCreateEditViewModel: Patient
    {
       public SelectList Doctors { get; set; }
       public SelectList Wards { get; set; }
       public SelectList Diagnoses { get; set; }
        [DataType(DataType.Upload)]
       public IFormFile PhotoUpload { get; set; }
        //to display errors
       public string ErrorMessage { get; set; }
    }
}
