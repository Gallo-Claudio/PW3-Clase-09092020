using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjercicioGenerics
{
    public class EjemploGenerics<T> where T : ISaludar
    {
        public string SaludarTodos(List<T> seresVivos)
        {
            string vitacoraDeRespiraciones = "";
            foreach (var serVivo in seresVivos)
            {
                vitacoraDeRespiraciones += Environment.NewLine + serVivo.Saludar();
            }

            return vitacoraDeRespiraciones;
        }
    }

    // SIN USAR GENERICS
    // *****************
    //public class EjemploGenerics
    //{
    //    public string SaludarTodos(List<ISaludar> seresVivos)
    //    {
    //        string vitacoraDeRespiraciones = "";
    //        foreach (var serVivo in seresVivos)
    //        {
    //            vitacoraDeRespiraciones += Environment.NewLine + serVivo.Saludar();
    //        }

    //        return vitacoraDeRespiraciones;
    //    }
    //}

}
