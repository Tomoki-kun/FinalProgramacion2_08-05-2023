using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    internal class Pedido
    {
        public double Valor
        {
            get; set;
        }
        public int Nro
        {
            get; set;
        }
        public DateTime FechaHora { get; set; }
        public string Detalle { get; set; }

        public Pedido(int nro, List<Producto> lista)
        {
            Nro = nro;
            double total = 0;
            foreach (Producto p in lista)
            {
                total += p.Precio(p.CantidadKilos);
            }
            Valor = total;
            FechaHora = DateTime.Now;
        }
        public string VerResumen()
        {
            return $"Pedido Nro: {Nro}\r\nFecha: {FechaHora.Date} Hora: {FechaHora.Hour}:{FechaHora.Minute}\r\nCliente: ";
        }
    }
}
