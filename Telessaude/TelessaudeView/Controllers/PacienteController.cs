using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TelessaudeView.Models;
using TelessaudeViewModel.Models;
using TelessaudeViewModel.Services.Interfaces;

namespace TelessaudeView.Controllers
{
    public class PacienteController : Controller
    {

        private readonly IPacienteService _service;

        public PacienteController(IPacienteService service, IMapper mapper)
        {
            _service = service;
        }

        // GET: PacienteController
        [HttpGet]
        // [Route("")]
        public async Task<ActionResult> Index()
        {
            try
            {
                var pacientes = await _service.GetAsync();
                return View("Index", pacientes);
            }
            catch (Exception e)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
        // GET: PacienteController/Details/5
        [HttpGet]
        [Route("Details/{id}")]
        public ActionResult Details(string id)
        {

            try
            {
                var paciente = _service.GetById(id);
                return View(paciente);
            }
            catch (Exception e)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        // GET: PacienteController/Create
        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Create")]
        public ActionResult Create([FromForm] PacienteViewModel paciente)
        {
            try
            {
                _service.AddOrUpdate(paciente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PacienteController/Edit/5
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

        // GET: PacienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PacienteController/Delete/5
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
