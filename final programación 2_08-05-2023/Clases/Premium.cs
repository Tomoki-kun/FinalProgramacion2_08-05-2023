using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    internal class Premium : Producto
    {
        private double precioBaseB;

        public Premium(string descripcion, double precioA, double precioB)
        {
            precioBaseB = precioB;
            precioBaseA = precioA;
            base.descripcion = descripcion;
        }
        public override double Precio(double kilo)
        {
            return (70 + (precioBaseA * 0.85 + precioBaseB * 0.15) * 1.8) * kilo;
        }
        public override string Descripcion()
        {
            return descripcion;
        }
    }
}
