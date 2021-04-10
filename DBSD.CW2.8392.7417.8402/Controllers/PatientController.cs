using DBSD.CW2._8392._7417._8402.DAL;
using DBSD.CW2._8392._7417._8402.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private IPatientRepository _repository;
        private IConfiguration _configuration;

        public PatientController(IPatientRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }
        // GET: PatientController
        public ActionResult Filter(
                int pageNum,
                string sortColumn,
                string sortDirection,
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
                                              sortColumn,
                                              pageNum,
                                              out int totalCount,
                                              "Desc".Equals(sortDirection, StringComparison.OrdinalIgnoreCase) ? true : false);

            filter.Patients = new StaticPagedList<Patient>(patients, pageNum, pageSize, totalCount);
            filter.CurrentPage = pageNum;
            filter.SortDirection = "DESC".Equals(sortDirection, StringComparison.OrdinalIgnoreCase)
                ? "ASC"
                : "DESC";


            return View(filter);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Patient patient)
        {
            try
            {
                _repository.Insert(patient);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
