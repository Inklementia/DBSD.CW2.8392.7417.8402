using DBSD.CW2._8392._7417._8402.DAL;
using DBSD.CW2._8392._7417._8402.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                var patient = MapViewModelToPatient(model);
                //TO DO: photo upload logic 
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
                var patient = MapViewModelToPatient(model);
                if(model.PhotoUpload!=null)
                {
                    //TO DO: photo upload logic
                } else
                {
                    //if user did not choose new photo, leave old one
                    patient.Photo = model.Photo;
                }
                _repository.Update(patient);
                return RedirectToAction(nameof(Index));
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

        private PatientCreateEditViewModel GetDataForSelectList(PatientCreateEditViewModel model)
        {

            model.Diagnoses = new SelectList(_repository.GetDiagnoses(), "Id", "Name");
                model.Doctors = new SelectList(_repository.GetDoctors(), "Id", "Name");
            model.Wards = new SelectList(_repository.GetWards(), "Id", "Number");
            return model;
        }
        private Patient MapViewModelToPatient (PatientCreateEditViewModel model)
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
    }
}
