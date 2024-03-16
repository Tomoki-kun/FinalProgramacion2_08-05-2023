using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    internal class ClienteCuenta : IComparable
    {
        public string Nombre { get; set; }
        public long Cuit { get; set; }
        public double SaldoCuenta { get; set; }
        public double Tope { get; set; }

        public Queue<Pedido> listaPedidos;
        public ClienteCuenta(string nombre, long cuit, double topeCuenta)
        {
            Nombre = nombre;
            Cuit = cuit;
            Tope = topeCuenta;
        }

        public double AgregarPedido(Pedido nuevoPedido)
        {
            double ret = 0;
            if (!(Tope < SaldoCuenta + nuevoPedido.Valor))
            {
                SaldoCuenta += nuevoPedido.Valor;
                listaPedidos.Enqueue(nuevoPedido);
                ret = SaldoCuenta;
            }
            return ret;
        }

        public Pedido RetirarPedido()
        {
            Pedido pedido = null;
            return pedido;
        }

        public bool AgregarPago(double monto)
        {
            bool ret = false;
            if (SaldoCuenta > monto)
            {
                SaldoCuenta -= monto;
                ret = true;
            }
            return ret;
        }

        public int CompareTo(Object obj)
        {
            return this.Cuit.CompareTo(((ClienteCuenta)obj).Cuit);
        }
    }
}
