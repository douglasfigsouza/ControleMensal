using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleMensal.Models;

namespace ControleMensal.Controllers
{
    public class HomeController : Controller
    {
        private ClientesRepository clientesRep;
        public HomeController()
        {
            this.clientesRep = new ClientesRepository();
        }
        public ActionResult addClientes()
        {
            ViewBag.Title = "Cadastro de Clientes";

            return View();
        }
        public ActionResult addServicos()
        {
            ViewBag.Title = "Venda";
            return View();
        }





        [HttpPost]
        public ActionResult addClientes(CLIENTES cliente)
        {
            clientesRep.addClientes(cliente);
            return RedirectToAction("addServicos", "Home");
        }
    }
}
