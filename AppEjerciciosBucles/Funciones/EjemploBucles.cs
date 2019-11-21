using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjerciciosBucles.Funciones
{
    public static class EjemploBucles
    {
        public static string saludar(int limite)
        {
            StringBuilder cad = new StringBuilder("Saludos" +Environment.NewLine);
            int i = 0;
            while (i<limite)
            {
                i++;
                cad.Append(i.ToString() + ": Hola" + Environment.NewLine);
            }
            

            return cad.ToString();
        }
    }
}
