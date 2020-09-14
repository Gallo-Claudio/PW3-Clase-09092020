using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    //enum EnumeracionSinClase
    //{
    //    Domingo = 1,
    //    Lunes = 2,
    //    Martes = 3,
    //    Miercoles = 4,
    //    Jueves = 5,
    //    Viernes = 6,
    //    Sabados = 7
    //}
    public class EjercicioEnumeraciones
    {
        public enum DiasDeLaSemana
        {
            Domingo = 1,
            Lunes = 2,
            Martes = 3,
            Miercoles = 4,
            Jueves = 5,
            Viernes = 6,
            Sabados = 7
        }

        public static string ObtenerNombreDiaDeLaSemana(DiasDeLaSemana diasDeLaSemana)
        {
            // Para usar el snippets, escribir swi.. hasta que aparezca, y luego presionar dos veces la tecla Tab.
            // Luego comenzar a escribir el parametro, hasta que aparezca el sugerido y luego presionar dos veces Enter
            switch (diasDeLaSemana)
            {
                case DiasDeLaSemana.Domingo:
                    return "Domingo";
                // break;  Se detecta como código inaccesible, por lo que se puede eliminar
                case DiasDeLaSemana.Lunes:
                    return "Lunes";
                case DiasDeLaSemana.Martes:
                    return "Martes";
                case DiasDeLaSemana.Miercoles:
                    return "Miercoles";
                case DiasDeLaSemana.Jueves:
                    return "Jueves";
                case DiasDeLaSemana.Viernes:
                    return "Viernes";
                case DiasDeLaSemana.Sabados:
                    return "Sabados";
                    // En este ejercicio el default no es necesario
                    //default:
                    //    return "";
            }

            return "";
        }
    }
}
