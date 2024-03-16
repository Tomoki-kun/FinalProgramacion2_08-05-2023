using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    internal abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA;

        public double CantidadKilos { get; set; }

        public abstract double Precio(double kilo);
        public abstract string Descripcion();
    }
}
