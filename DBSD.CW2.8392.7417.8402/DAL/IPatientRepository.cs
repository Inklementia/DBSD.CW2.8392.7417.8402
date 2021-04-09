using DBSD.CW2._8392._7417._8402.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.DAL
{
    public interface IPatientRepository
    {
        public List<Patient> GetPatients();

        public List<Patient> Filter(
                string name,
                string address,
                DateTime? registeredDate,
                string diagnoseName,
                string doctorName,
                //out int totalCount, not sure about these
                //string sortColumn, 
                bool orderDesc = false,
                int? pageNum = 1,
                int pageSize = 4
            );

        public void Insert(Patient entity);

        public void Update(Patient entity);

        public Patient GetById(int id);

        public void Delete(int id);
    }
}
