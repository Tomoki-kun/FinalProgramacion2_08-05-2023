using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_programación_2_08_05_2023.Clases
{
    internal class GestionVenta
    {
        private Empresa dueño;
        private double montoFacturado;
        private readonly DateTime inicioOperaciones;
        public ArrayList listaClientes;
        public List<Producto> lista;

        public GestionVenta(long cuit, string razonSocial)
        {
            dueño = new Empresa(cuit, razonSocial);
        }

        public void AgregarCliente(ClienteCuenta unCliente)
        {
            if (unCliente != null)
            {
                listaClientes.Add(unCliente);
            }
        }

        public ClienteCuenta BuscarCliente(long cuit)
        {
            ClienteCuenta buscado = new ClienteCuenta("", cuit, 0);
            int pos = listaClientes.BinarySearch(buscado);
            if (pos == 0)
                buscado = (ClienteCuenta)listaClientes[pos];
            else
                buscado = null;
            return buscado;
        }
        public Pedido GenerarPedido(int nro, List<Producto> lista)
        {

        }
        public bool SumarPedido(ClienteCuenta cliente, Pedido nuevoPedido)
        {

        }

        public bool AgregarPago(long cuit, double monto)
        {

        }

        public double VerSaldo(long cuit)
        {

        }
    }
}
