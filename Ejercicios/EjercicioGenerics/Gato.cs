using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjercicioGenerics
{
    public class Gato : ISaludar
    {
        public string Nombre { get; set; }
        public string Saludar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Miau Miau ");
            sb.Append(Nombre);
            return sb.ToString();
        }
    }
}

