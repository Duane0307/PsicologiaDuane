using ConsultorioPsicologiaDuane.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsultorioPsicologiaDuane.Controllers
{
    public class HomeController : Controller
    {
        private PsicologaDbContext _db;
        public HomeController()
        {
            _db = new PsicologaDbContext();
        }
        public HomeController(PsicologaDbContext db)
        {
            _db = new PsicologaDbContext();
        }
        public ActionResult Index()
        {
            var pacientes = _db.Pacientes.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Pacientes()
        {
            var pacientes = _db.Pacientes.ToList();
            return View(pacientes);
        }

        [HttpPost]
        public ActionResult ConsultarDados(string name)
        {
            var teste = "duifsiurh";
            var pacientes = _db.Pacientes.ToList();
            return View("Pacientes", pacientes);
        }

        [HttpPost]
        public ActionResult CadastrarPaciente(Paciente paciente)
        {
            _db.Pacientes.Add(paciente);
            _db.SaveChanges();
            return RedirectToAction("Pacientes");
        }

        [HttpPost]
        public ActionResult ExcluirRegistro(int id)
        {
            // Lógica para excluir o registro com o ID especificado
            // Por exemplo:
            var registro = _db.Pacientes.Find(id);
            if (registro != null)
            {
                _db.Pacientes.Remove(registro);
                _db.SaveChanges();
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, errorMessage = "Registro não encontrado" });
            }
        }
    }
}