using Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DiasDeLaSemana()
        {
            Random ran = new Random(DateTime.Now.Millisecond);
            int numeroAleatorio = ran.Next(1, 8);
            string resultadoNombreDia = EjercicioEnumeraciones.ObtenerNombreDiaDeLaSemana((EjercicioEnumeraciones.DiasDeLaSemana)numeroAleatorio);
            ViewBag.NombreDia = resultadoNombreDia;
            return View();
        }

    }
}