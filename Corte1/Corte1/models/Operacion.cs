using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Operacion
    {
        public int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad = DateTime.Now.Year - fechaDeNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaDeNacimiento.DayOfYear)
            {
                edad--;
            }
            return edad;
        }

        public bool EsMayorDeEdad(DateTime fechaDeNacimiento)
        {
            int edad = CalcularEdad(fechaDeNacimiento);
            return edad >= 18;
        }
    }
}
