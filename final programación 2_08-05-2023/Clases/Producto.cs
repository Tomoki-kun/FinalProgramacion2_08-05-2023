using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    [Serializable]
    internal abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA;

        public double CantidadKilos { get; set; }

        public abstract double Precio(double kilo);
        public abstract string Descripcion();

        public override string ToString()
        {
            return string.Format("{0, -20} {1, -10} {2, -10} {3, -10}\n", this.descripcion, CantidadKilos, Precio(1), Precio(CantidadKilos));
        }
    }
}
