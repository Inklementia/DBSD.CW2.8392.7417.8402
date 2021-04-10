using DBSD.CW2._8392._7417._8402.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.DAL
{
    public interface IPatientRepository
    {

        public List<Patient> Filter(
                string name,
                string address,
                DateTime? registeredDate,
                string diagnoseName,
                string doctorName,
                int pageSize,
                string sortColumn,
                int? pageNum,
                out int rowsCount,
                bool orderDesc = false
            );

        public void Insert(Patient entity);
        public void BulkInsert(List<Patient> patients);

        public void Update(Patient entity);

        public Patient GetById(int id);

        public void Delete(int id);

        //not sure whether we need it, but I guess that we need
        public List<Ward> GetWards();
        public List<Diagnose> GetDiagnoses();
        public List<Doctor> GetDoctors();

    }
}
