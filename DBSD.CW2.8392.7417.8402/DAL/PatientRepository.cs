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
        public void BulkInsert(IList<Patient> patients)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var table = new DataTable("patientTable");
                table.Columns.Add("firstName", typeof(string));
                table.Columns.Add("lastName", typeof(string));
                table.Columns.Add("dob", typeof(string));
                table.Columns.Add("occupation", typeof(string)).AllowDBNull = true;
                table.Columns.Add("gender", typeof(int));
                table.Columns.Add("phone", typeof(string));
                table.Columns.Add("address", typeof(string));
                table.Columns.Add("diagnoseId", typeof(int)).AllowDBNull = true;
                table.Columns.Add("doctorId", typeof(int)).AllowDBNull = true ;
                table.Columns.Add("wardId", typeof(int)).AllowDBNull = true ;
                table.Columns.Add("photo", typeof(byte[])).AllowDBNull = true ;
                table.Columns.Add("emergencyHospitalization", typeof(bool));
                table.Columns.Add("isDischarged", typeof(bool)).AllowDBNull = true;

                foreach(Patient patient in patients)
                {
                    table.Rows.Add(patient.FirstName, patient.LastName, patient.DoB,
                                   patient.Occupation, patient.Gender, patient.Phone,
                                   patient.Address, patient.DiagnoseId, patient.DoctorId,
                                   patient.WardId, patient.Photo, patient.EmergencyHospitalization, patient.IsDischarged);
                }
                var procedure = "udp_patient_bulk_insert";
                connection.Execute(procedure, new { @patientTable = table }, commandType: CommandType.StoredProcedure);
            }
        }
        public void Update(Patient entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var procedure = "udp_update_patient";
                var parameters = new DynamicParameters();
                parameters.Add("@id", entity.Id);
                parameters.Add("@firstName", entity.FirstName);
                parameters.Add("@lastName", entity.LastName);
                parameters.Add("@dob", entity.DoB);
                parameters.Add("@occupation", entity.Occupation);
                parameters.Add("@gender", entity.Gender);
                parameters.Add("@phone", entity.Phone);
                parameters.Add("@address", entity.Address);
                parameters.Add("@registeredDate", entity.RegisteredDate);
                parameters.Add("@diagnoseId", entity.DiagnoseId);
                parameters.Add("@doctorId", entity.DoctorId);
                parameters.Add("@wardId", entity.WardId);
                parameters.Add("@emergencyHospitalization", entity.EmergencyHospitalization);
                parameters.Add("@isDischarged", entity.IsDischarged);
                if (entity.Photo != null)
                {
                    parameters.Add("@photo", entity.Photo);
                }

                connection.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(int id)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                var procedure = "udp_delete_patient";
                var parameters = new DynamicParameters();
                parameters.Add("@id", id);
                connection.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
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
            using (var connection = new SqlConnection(_connectionString))
            {
                var procedure = "udp_get_by_id";
                var parameters = new DynamicParameters();
                parameters.Add("@id", id);
                var patient = connection.Query<Patient>(procedure, parameters,commandType:CommandType.StoredProcedure).Single();
                return patient;
            }
        }

        public List<Diagnose> GetDiagnoses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = "select id, name from diagnose";
                var list = connection.Query<Diagnose>(command, commandType: CommandType.Text).AsList();
                return list;
            }
        }

        public List<Doctor> GetDoctors()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = "select id, concat(lastName,' ',firstName) as name from doctor";
                var list = connection.Query<Doctor>(command, commandType: CommandType.Text).AsList();
                return list;
            }
        }

        public List<Ward> GetWards()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = "select id, number from ward";
                var list = connection.Query<Ward>(command, commandType: CommandType.Text).AsList();
                return list;
            }
        }

    }
}
