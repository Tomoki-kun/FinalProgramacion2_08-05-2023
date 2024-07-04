using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_programación_2_08_05_2023.Clases
{
    [Serializable]
    internal class GestionVenta  
    {
        private Empresa dueño;
        private double montoFacturado = 0;
        private readonly DateTime inicioOperaciones;
        public ArrayList listaClientes = new ArrayList();
        public List<Producto> lista = new List<Producto>();

        public GestionVenta(long cuit, string razonSocial)
        {
            dueño = new Empresa(cuit, razonSocial);
            inicioOperaciones = DateTime.Now;
        }

        public void AgregarCliente(ClienteCuenta unCliente)
        {
            if (unCliente != null)
            {
                int pos = listaClientes.BinarySearch(unCliente);
                if (pos < 0)
                    listaClientes.Add(unCliente);
            }
        }

        public ClienteCuenta BuscarCliente(long cuit)
        {
            ClienteCuenta buscado = new ClienteCuenta("", cuit, 0);
            int pos = listaClientes.BinarySearch(buscado);
            if (pos >= 0)
                buscado = (ClienteCuenta)listaClientes[pos];
            else
                buscado = null;
            return buscado;
        }
        public Pedido GenerarPedido(int nro, List<Producto> lista)
        {
            Pedido pedido = new Pedido(nro, lista);
            return pedido;
        }
        public bool SumarPedido(ClienteCuenta cliente, Pedido nuevoPedido)
        {
            bool agregado = false;
            int pos = listaClientes.IndexOf(cliente);
            if (pos >= 0 && cliente != null && cliente.AgregarPedido(nuevoPedido) != -1)
            {
                agregado = true;
                listaClientes[pos] = cliente;
                this.montoFacturado += cliente.SaldoCuenta;
            }
            return agregado;
        }

        public bool AgregarPago(long cuit, double monto)
        {
            bool agregado = false;
            ClienteCuenta buscado = new ClienteCuenta("", cuit, 0);
            int pos = listaClientes.BinarySearch(buscado);
            if (pos >= 0)
            {
                buscado.AgregarPago(monto);
                agregado = true;
            }
            return agregado;
        }

        public double VerSaldo(long cuit)
        {
            double saldo = 0;
            ClienteCuenta buscado = new ClienteCuenta("", cuit, 0);
            int pos = listaClientes.BinarySearch(buscado);
            if (pos >= 0)
            {
                saldo = buscado.SaldoCuenta;
            }
            return saldo;
        }

    }
}
