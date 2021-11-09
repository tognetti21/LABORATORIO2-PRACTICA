using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaForms
{
    public class Piso : Inmueble
    {
        
        
        public double ingresarPiso(double precio, int numPiso, int anios)
        {
            if (anios < 15)
            {
                precio -= (precio * 0.01);
            }
            else
            {
                precio -= (precio * 0.02);
            }
            if (numPiso >= 3)
            {
                precio += (precio * 0.03);
            }
            return precio;
        }

        

        
    }
}
