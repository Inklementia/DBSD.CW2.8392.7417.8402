using DBSD.CW2._8392._7417._8402.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSD.CW2._8392._7417._8402.DAL
{
    public class PatientRepository : IPatientRepository
    {
        private readonly string _connectionString;
        public PatientRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Insert(Patient entity)
        {
            throw new NotImplementedException();
        }
        public void BulkInsert(List<Patient> patients)
        {
            throw new NotImplementedException();
        }
        public void Update(Patient entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> Filter(string name, string address, DateTime? registeredDate, string diagnoseName, string doctorName, int totalCount, int pageSize, string sortColumn, bool orderDesc = false, int? pageNum = 1)
        {
            throw new NotImplementedException();
        }

        public Patient GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Diagnose> GetDiagnoses()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctors()
        {
            throw new NotImplementedException();
        }

        public List<Ward> GetWards()
        {
            throw new NotImplementedException();
        }


    }
}
