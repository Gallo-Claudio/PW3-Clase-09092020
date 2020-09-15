using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioRef
    {
        public static string TruncarTexto(ref string texto, int cantidad)
        {
            texto = texto.Substring(0, cantidad);
            return texto;
        }
    }
}
