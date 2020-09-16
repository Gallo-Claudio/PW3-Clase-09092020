using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjercicioGenerics
{
    public class Perro : ISaludar
    {
        public string Nombre { get; set; }
        public string Saludar()
        {
            return string.Format("Gua Gua {0} ", Nombre);
        }
    }
}
