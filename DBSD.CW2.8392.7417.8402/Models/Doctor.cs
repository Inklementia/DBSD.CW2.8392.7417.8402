using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.Models
{
    public class Doctor
    {
        public int? DoctorId { get; set; }

        [DisplayName("Doctor Name")]
        public string DoctorName { get; set; }
    }
}
