using Dapper;
using DBSD.CW2._8392._7417._8402.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            using (var connection = new SqlConnection(_connectionString))
            {
                var procedure = "udp_create_patient";
                var parameters = new DynamicParameters();
                parameters.Add("@firstName", entity.FirstName);
                parameters.Add("@lastName", entity.LastName);
                parameters.Add("@dob", entity.DoB);
                parameters.Add("@occupation", entity.Occupation);
                parameters.Add("@gender", entity.Gender);
                parameters.Add("@phone", entity.Phone);
                parameters.Add("@address", entity.Address);
                parameters.Add("@diagnoseId", entity.DiagnoseId);
                parameters.Add("@doctorId", entity.DoctorId);
                parameters.Add("@wardId", entity.WardId);
                parameters.Add("@emergencyHospitalization", entity.EmergencyHospitalization);
                if(entity.Photo!=null)
                {
                    parameters.Add("@photo", entity.Photo);
                }

                connection.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
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

        public List<Patient> Filter(string name, string address, DateTime? registeredDate, string diagnoseName, string doctorName, int pageSize, string sortColumn, int? pageNum, out int rowsCount ,bool orderDesc = false)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                //filtering
                if(!string.IsNullOrWhiteSpace(name))
                {
                    parameters.Add("@name", name);
                }
                if(!string.IsNullOrWhiteSpace(address))
                {
                    parameters.Add("@address", address);
                }
                if (registeredDate.HasValue)
                {
                    parameters.Add("@registeredDate", registeredDate.ToString());
                }
                if(!string.IsNullOrWhiteSpace(diagnoseName))
                {
                    parameters.Add("@diagnoseName", diagnoseName);
                }
                if(!string.IsNullOrWhiteSpace(doctorName))
                {
                    parameters.Add("@doctorName", doctorName);
                }

                //sorting
                if(!string.IsNullOrWhiteSpace(sortColumn))
                {
                    parameters.Add("@orderBy", sortColumn);
                }
                if(orderDesc)
                {
                    parameters.Add("@orderDesc", 1);
                }
                //paging
                if (!pageNum.HasValue || pageNum <= 0)
                    pageNum = 1;

                if (pageSize <= 0)
                    pageSize = 4;
                parameters.Add("@pageNum", pageNum);
                parameters.Add("@pageSize", pageSize);
                parameters.Add("@rowsCount", DbType.Int32, direction: ParameterDirection.Output);

                var procedure = "udp_filter_patients";
                var filteredPatients = connection.Query<Patient>(procedure, parameters, commandType:CommandType.StoredProcedure).AsList();
                rowsCount = parameters.Get<int>("@rowsCount");
                return filteredPatients;
            }
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
