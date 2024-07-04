using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_programación_2_08_05_2023.Clases
{
    [Serializable]
    internal class ClienteCuenta : IComparable , ISavable
    {
        public string Nombre { get; set; }
        public long Cuit { get; set; }
        public double SaldoCuenta { get; set; }
        public double Tope { get; set; }

        public Queue<Pedido> listaPedidos = new Queue<Pedido>();
        public ClienteCuenta(string nombre, long cuit, double topeCuenta)
        {
            Nombre = nombre;
            Cuit = cuit;
            Tope = topeCuenta;
        }

        public double AgregarPedido(Pedido nuevoPedido)
        {
            double ret = -1;
            if (!(Tope < SaldoCuenta + nuevoPedido.Valor))
            {
                SaldoCuenta += nuevoPedido.Valor;
                string cliente = $"Cliente: {Nombre}\nCuit: {Cuit}";
                nuevoPedido.Detalle = cliente + nuevoPedido.Detalle;
                listaPedidos.Enqueue(nuevoPedido);
                ret = SaldoCuenta;
            }
            return ret;
        }

        public Pedido RetirarPedido()
        {
            Pedido pedido = null;
            if (listaPedidos.Count != 0)
                pedido = listaPedidos.Dequeue();
            return pedido;
        }

        public bool AgregarPago(double monto)
        {
            bool ret = false;
            if (SaldoCuenta >= monto && listaPedidos.Peek().Valor == monto)
            {
                SaldoCuenta -= monto;
                RetirarPedido();
                ret = true;
            }
            return ret;
        }

        public int CompareTo(Object obj)
        {
            return this.Cuit.CompareTo(((ClienteCuenta)obj).Cuit);
        }

        public bool Escribir(string ruta)
        {
            bool guardado = false;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                if (File.Exists(ruta))
                    File.Delete(ruta);
                fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(this.Nombre + ";" + this.Cuit + ";" + this.SaldoCuenta);
                guardado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar" + ex.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            return guardado;
        }
    }
}
