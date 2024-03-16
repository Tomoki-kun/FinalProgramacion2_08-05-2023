using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    internal class Empresa
    {
        private long cuit;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Empresa(long cuit, string razonSocial)
        {
            this.cuit = cuit;
            RazonSocial = razonSocial;
        }

        public override string ToString()
        {
            return $"Cuit: {cuit}\nRazon social: {RazonSocial}\nDireccion: {Direccion}";
        }
    }
}
