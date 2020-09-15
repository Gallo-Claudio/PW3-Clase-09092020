using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioOut  // Para poder ser accedida desde afuera tiene que tener el modificador de acceso en Public
    {
        
        // Por regla se pueden pasar varios parametros a un metodo, pero solo devuelve uno
        // *******************************************************************************

        //public static string InvertirTexto(string cadena)
        //{
        //    // sacado de "https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string"
        //    char[] charArray = cadena.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}


        // Como alternativa para devolver varios parametros, podemos devolver un objeto (La opcion mas usada) o usar Out (no esta muy recomendado)
        // ***************************************************************************************************************************************
        
        public static string InvertirTexto(string cadena, out string cadenaMod, out string cadenaMod2)
        {
            // sacado de "https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string"
            char[] charArray = cadena.ToCharArray();
            Array.Reverse(charArray);
            cadenaMod = "***"+new string(charArray)+"***";
            cadenaMod2 = "---"+new string(charArray)+"---";
            return new string(charArray);
        }

    }

    // Extension Method - Extension personalizada de un metodo, para agregar una funcionalidad
    // Se debe crear la clase y el metodo con modificador de acceso Static
    // Para usarla es necesario agregar el Using.Namespace (correspondiente)
    public static class ExtensionString
    {
        public static string Cortar(this string text, int cantidad)
        {
            return text.Substring(0, cantidad);
        }
    }
}
