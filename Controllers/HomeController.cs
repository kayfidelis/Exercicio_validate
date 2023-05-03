using ExeKayqueIV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeKayqueIV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cliente(Cliente objCliente)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", objCliente);
            }
            return View();
        }
        public ActionResult Resultado(Cliente ObjCliente)
        {
            return View(ObjCliente);
        }

        public ActionResult SelectLogin(string login)
        {
            var ExeKayqueIV = new Collection<string>
            {
                "Prático",
                "Heitor",
                "Cícero"
            };
            return Json(ExeKayqueIV.All(a => a.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);

        }

        public ActionResult Selectcpf(long CPF)
        {
            var ExeKayqueIV = new Collection<long>
            {
                11122233311,
                11122233312,
                11122233313
            };
            return Json(ExeKayqueIV.All(a => a != CPF), JsonRequestBehavior.AllowGet);

        }
        public ActionResult SelectDate(DateTime DataCadastro)
        {
            DateTime hoje = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            bool validate = hoje <= DataCadastro;

            return Json(validate, JsonRequestBehavior.AllowGet);
        }

    }
}