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

        public ActionResult EjercicioOut()
        {
            string textoOriginal = "Abracadabra";
            // En este caso al llamarse de igual forma el ActionResult y la clase (que contiene el metodo que queremos usar), se produce una ambiguedad
            // Hay tres formas de saltar este error
            // 1 - Renombrar el ActionResult o la Clase
            // 2 - Usar el namespace completo (Por lo que hay que anteponer al nombre de la clase, el nombre del proyecto)
            // 3 - Crear un alias del namespace en el Using (ej using ej = Ejercicios;) y luego hacer referncia al alias
            string salida1;
            string salida2;
            string textoInvertido = Ejercicios.EjercicioOut.InvertirTexto(textoOriginal, out salida1, out salida2);
            
            @ViewBag.textoOriginal = textoOriginal;
            @ViewBag.TextoInvertido = textoInvertido;
            @ViewBag.TextoOut = salida1;
            @ViewBag.TextoOut2 = salida2;
            return View();
        }
    }
}