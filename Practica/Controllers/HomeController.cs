﻿using Ejercicios;
using Ejercicios.EjercicioGenerics;
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

            ViewBag.textoOriginal = textoOriginal;
            ViewBag.TextoInvertido = textoInvertido;
            ViewBag.TextoOut = salida1;
            ViewBag.TextoOut2 = salida2;
            return View();
        }

        public ActionResult EjercicioRef()
        {
            string textoOriginal = "Abracadabra";
            string textoFinal = textoOriginal;
            Ejercicios.EjercicioRef.TruncarTexto(ref textoFinal, 4);

            ViewBag.textoOriginal = textoOriginal;
            ViewBag.TextoOut = textoFinal;
            return View();
        }

        public ActionResult EjercicioGenerics()
        {
            EjemploGenerics<ISaludar> ejemploGenerics = new EjemploGenerics<ISaludar>();

            List<ISaludar> animalesQueSaludan = new List<ISaludar>();
            animalesQueSaludan.Add(new Perro() { Nombre = "Diogenes" });
            animalesQueSaludan.Add(new Gato() { Nombre = "Macri" });
            animalesQueSaludan.Add(new Pez() { Nombre = "Nemo" });

            string saludo = ejemploGenerics.SaludarTodos(animalesQueSaludan);

            ViewBag.SaludoGrupal = saludo;
            return View();
        }

        // SIN USAR GENERICS
        // *****************
        //public ActionResult EjercicioGenerics()
        //{
        //    EjemploGenerics ejemploGenerics = new EjemploGenerics();

        //    List<ISaludar> animalesQueSaludan = new List<ISaludar>();
        //    animalesQueSaludan.Add(new Perro() {Nombre = "Diogenes"});
        //    animalesQueSaludan.Add(new Gato() { Nombre = "Macri" });
        //    animalesQueSaludan.Add(new Pez() { Nombre = "Nemo" });

        //    string saludo = ejemploGenerics.SaludarTodos(animalesQueSaludan);

        //    ViewBag.SaludoGrupal = saludo;
        //    return View();
        //}
    }
}