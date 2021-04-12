using CsvHelper;
using DBSD.CW2._8392._7417._8402.DAL;
using DBSD.CW2._8392._7417._8402.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X.PagedList;

namespace DBSD.CW2._8392._7417._8402.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _repository;
        private readonly IConfiguration _configuration;

        public PatientController(IPatientRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        #region CRUD
        // GET: PatientController
        public ActionResult Filter(
                int pageNum,
                PatientFilterViewModel filter
            )
        {
            if (pageNum <= 0)
                pageNum = 1;
            int pageSize = _configuration.GetValue<int>("ViewSettings:PageSize");
            var patients = _repository.Filter(filter.Name,
                                              filter.Address,
                                              filter.RegisteredDate,
                                              filter.DiagnoseName,
                                              filter.DoctorName,
                                              pageSize, 
                                              filter.SortColumn.ToString(),
                                              pageNum,
                                              out int totalCount,
                                             filter.SortDesc);

            filter.Patients = new StaticPagedList<Patient>(patients, pageNum, pageSize, totalCount);
            filter.CurrentPage = pageNum;

            return View(filter);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            //TO DO: display image logic
            var patient = _repository.GetById(id);
            return View(patient);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            var model = new PatientCreateEditViewModel();
            return View(GetDataForSelectList(model));
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatientCreateEditViewModel model)
        {
          
            try
            {
                //photo upload 
                byte[] photoBytes = null;
                if(model.PhotoUpload != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        model.PhotoUpload.CopyTo(memory);
                        photoBytes = memory.ToArray();
                    }
                }
                var patient = MapViewModelToPatient(model, photoBytes);
                
                _repository.Insert(patient);

                return RedirectToAction(nameof(Filter));
            }
          
           catch(Exception ex)
            {
                model.ErrorMessage = ex.Message;
                return View(model);

            }
          
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            //TO DO: display image logic
            var patient = _repository.GetById(id);
            var model = MapPatientToViewModel(patient);
            return View(model);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PatientCreateEditViewModel model)
        {
            try
            {
                byte[] photoBytes = null;
                var patient = MapViewModelToPatient(model, photoBytes);
                if(model.PhotoUpload != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        model.PhotoUpload.CopyTo(memory);
                        photoBytes = memory.ToArray();
                    }
                    patient.Photo = photoBytes;
                } else
                {
                    //if user did not choose new photo, leave old one
                    patient.Photo = model.Photo;
                }
                _repository.Update(patient);
                return RedirectToAction(nameof(Filter));
            }
            catch(Exception ex)
            {
                model.ErrorMessage = ex.Message;
                return View(model);
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            //TO DO: display image logic
            var patient = _repository.GetById(id);
            return View(patient);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Patient patient)
        {
            try
            {
                _repository.Delete(id);
                return RedirectToAction(nameof(Filter));
            }
            catch
            {
                return View(patient);
            }
        }
        #endregion CRUD

        #region Exporting

        // Export Json file method
        public ActionResult ExportJson(PatientFilterViewModel model)
        {
            var patientsList = _repository.Filter(model.Name,
                                              model.Address,
                                              model.RegisteredDate,
                                              model.DiagnoseName,
                                              model.DoctorName,
                                              1000_0000,
                                              null,
                                              1,
                                              out int totalCount,
                                              false);


            var patientListWithoutFKs = patientsList.Select(x => new {
                x.Id,
                x.FirstName,
                x.LastName,
                x.DoB,
                x.Occupation,
                x.Gender,
                x.Phone,
                x.Address,
                x.RegisteredDate,
                x.EmergencyHospitalization,
                x.IsDischarged,
                x.DiagnoseName,
                x.DoctorName,
                x.DepartmentName,
                x.NurseName,
                x.WardNo
            }).ToList();

            var memory = new MemoryStream();
            var writer = new StreamWriter(memory);
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            serializer.Serialize(writer, patientListWithoutFKs);
            writer.Flush();

            memory.Position = 0;
            if (memory != Stream.Null)
                return File(memory, "application/json", $"Export_{DateTime.Now.ToString("yy_mm_ss_ff")}.json");

            return NotFound();
        }

        // Export Xml file method
        public ActionResult ExportXml(PatientFilterViewModel model)
        {
            var patientsList = _repository.Filter(model.Name,
                                              model.Address,
                                              model.RegisteredDate,
                                              model.DiagnoseName,
                                              model.DoctorName,
                                              1000_0000,
                                              null,
                                              1,
                                              out int totalCount,
                                              false);

            var memory = new MemoryStream();
            var writer = new StreamWriter(memory);
            var serializer = new XmlSerializer(typeof(List<Patient>));
            serializer.Serialize(writer, patientsList);
            writer.Flush();

            memory.Position = 0;
            if (memory != Stream.Null)
                return File(memory, "application/xml", $"Export_{DateTime.Now.ToString("yy_mm_ss_ff")}.xml");

            return NotFound();
        }

        // Export Csv file method
        public ActionResult ExportCsv(PatientFilterViewModel model)
        {
            var patientsList = _repository.Filter(model.Name,
                                              model.Address,
                                              model.RegisteredDate,
                                              model.DiagnoseName,
                                              model.DoctorName,
                                              1000_0000,
                                              null,
                                              1,
                                              out int totalCount,
                                              false);

            var memory = new MemoryStream();
            var writer = new StreamWriter(memory);
            var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.Context.RegisterClassMap<PatientCSVExportHeadersMap>();
            csvWriter.WriteRecords(patientsList);
            writer.Flush();

            memory.Position = 0;
            if (memory != Stream.Null)
                return File(memory, "text/csv", $"Export_{DateTime.Now.ToString("yy_mm_ss_ff")}.csv");

            return NotFound();
        }

        #endregion Exporting

        #region Importing

        public ActionResult ImportJson()
        {
            return View();
        }

        // POST: Patient/ImportJson
        [HttpPost]
        public ActionResult ImportJson(IFormFile importFile)
        {
            IList<Patient> patients = null;
            if (importFile != null)
            {
                using (var stream = importFile.OpenReadStream())
                using (var reader = new StreamReader(stream))
                {
                    var serializer = new JsonSerializer();
                    patients = (List<Patient>)serializer.Deserialize(reader, typeof(List<Patient>));
                }

                _repository.BulkInsert(patients);
            }
            else
            {
                ModelState.AddModelError("", "Empty file");
            }

            return View(patients);
        }


        public ActionResult ImportCsv()
        {
            return View();
        }

        // POST: Patient/ImportCsv
        [HttpPost]
        public ActionResult ImportCsv(IFormFile importFile)
        {
            List<Patient> patients = null;
            if (importFile != null)
            {
                using (var stream = importFile.OpenReadStream())
                using (var reader = new StreamReader(stream))
                {
                    var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
                    csvReader.Context.RegisterClassMap<PatientCSVImportHeadersMap>();
                    patients = csvReader.GetRecords<Patient>().ToList<Patient>();
                }

                _repository.BulkInsert(patients);
            }
            else
            {
                ModelState.AddModelError("", "Empty file");
            }

            return View(patients);
        }

        // view for import
        public ActionResult ImportXml()
        {
            return View();
        }

        // Method for importing Xml file
        // POST: Patient/ImportXml
        [HttpPost]
        public ActionResult ImportXml(IFormFile importFile)
        {
            var patients = new List<Patient>();
            if (importFile != null)
            {
                using (var stream = importFile.OpenReadStream())
                using (var reader = new StreamReader(stream))
                {
                    var serializer = new XmlSerializer(typeof(List<Patient>));
                    patients = (List<Patient>)serializer.Deserialize(reader);
                }

                _repository.BulkInsert(patients);
            }
            else
            {
                ModelState.AddModelError("", "Empty file");
            }

            return View(patients);
        }

        #endregion Importing

        #region Other
        private PatientCreateEditViewModel GetDataForSelectList(PatientCreateEditViewModel model)
        {

            model.Diagnoses = new SelectList(_repository.GetDiagnoses(), "Id", "Name");
                model.Doctors = new SelectList(_repository.GetDoctors(), "Id", "Name");
            model.Wards = new SelectList(_repository.GetWards(), "Id", "Number");
            return model;
        }
        private Patient MapViewModelToPatient (PatientCreateEditViewModel model, byte[] photoBytes)
        {
            var patient = new Patient
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DoB = model.DoB,
                Occupation = model.Occupation,
                Gender = model.Gender,
                Phone = model.Phone,
                Address = model.Address,
                Photo = photoBytes,
                DoctorId = model.DoctorId,
                DiagnoseId = model.DiagnoseId,
                WardId = model.WardId,
                RegisteredDate = model.RegisteredDate,
                EmergencyHospitalization = model.EmergencyHospitalization,
                IsDischarged = model.IsDischarged
            };
            return patient;
        }
        private PatientCreateEditViewModel MapPatientToViewModel(Patient patient)
        {
            var model = new PatientCreateEditViewModel
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                DoB = patient.DoB,
                Occupation = patient.Occupation,
                Gender = patient.Gender,
                Phone = patient.Phone,
                Address = patient.Address,
                DoctorId = patient.DoctorId,
                DiagnoseId = patient.DiagnoseId,
                WardId = patient.WardId,
                RegisteredDate = patient.RegisteredDate,
                EmergencyHospitalization = patient.EmergencyHospitalization,
                IsDischarged = patient.IsDischarged,
                Photo = patient.Photo
            };
            return GetDataForSelectList(model);
        }

        public ActionResult ShowImage(int? id)
        {
            if (id.HasValue)
            {
                var patient = _repository.GetById(id ?? -1);
                if(patient?.Photo != null)
                {
                    return File(patient.Photo, "image/jpeg", $"patient_photo_{id}.jpg");
                }
            }
            return NotFound();
        }

        #endregion Other
    }
}
