using final_programación_2_08_05_2023.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023
{
    internal class Clasico : Producto
    {
        public Clasico(double precioA, string descripcion)
        {
            precioBaseA = precioA;
            base.descripcion = descripcion;
        }

        public override double Precio(double kilo)
        {
            return (50 + (precioBaseA * 1.4)) * kilo;
        }
        public override string Descripcion() { return descripcion; }
    }
}
