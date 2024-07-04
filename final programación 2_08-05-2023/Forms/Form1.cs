using final_programación_2_08_05_2023.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_programación_2_08_05_2023
{
    public partial class Form1 : Form
    {
        GestionVenta gestionVenta;
        Producto productoSeleccionado;
        List<Producto> seleccionados = new List<Producto>();
        int nroPedido;
        ClienteCuenta clienteActual;
        BinaryFormatter binForm;
        string archivoSer = Application.StartupPath + "\\datosGestion.dat";
        public Form1()
        {
            InitializeComponent();
            productoSeleccionado = null;
            clienteActual = null;
            nroPedido = 0;
            Deserializar();
            foreach( Producto producto in gestionVenta.lista)
            {
                cbProducto.Items.Add(producto.Descripcion());
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializar();
        }

        private void Deserializar()
        {
            try
            {
                if (File.Exists(archivoSer))
                {
                    FileStream fs = new FileStream(archivoSer, FileMode.Open, FileAccess.Read);
                    binForm = new BinaryFormatter();

                    gestionVenta = (GestionVenta) binForm.Deserialize(fs);
                }
                else
                {
                    gestionVenta = new GestionVenta(30123456789, "Alimentos caninos");
                    ClienteCuenta cliente1 = new ClienteCuenta("Tomi", 1, 15000);
                    ClienteCuenta cliente2 = new ClienteCuenta("Toma", 12345678902, 30000);
                    ClienteCuenta cliente3 = new ClienteCuenta("Tomo", 12345678904, 70000);

                    Producto producto1 = new Premium("Dog Chow", 123.4, 222.4);
                    gestionVenta.lista.Add(producto1);
                    Producto producto2 = new Premium("Kongo", 13.4, 888.4);
                    gestionVenta.lista.Add(producto2);

                    Producto producto3 = new Clasico(468.9, "Whiskas");
                    gestionVenta.lista.Add(producto3);
                    Producto producto4 = new Clasico(555.5, "Royal Canin");
                    gestionVenta.lista.Add(producto4);

                    gestionVenta.AgregarCliente(cliente1);
                    gestionVenta.AgregarCliente(cliente2);
                    gestionVenta.AgregarCliente(cliente3);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al serializar archivo. " + e.Message, "¡ERROR!", MessageBoxButtons.OK);
            }
            
        }

        private void Serializar()
        {
            if (File.Exists(archivoSer))
                File.Delete(archivoSer);

            try
            {
                binForm = new BinaryFormatter();
                FileStream fs = new FileStream(archivoSer, FileMode.Create, FileAccess.Write);
                binForm.Serialize(fs, gestionVenta);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al serializar archivo. " + ex.Message, "¡ERROR!", MessageBoxButtons.OK);
            }
        }

        private void btnAddSelect_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbCUIT.Text);

            clienteActual = gestionVenta.BuscarCliente(cuit);
            if (clienteActual != null)
            {
                btnVerSaldo.Enabled = true;
                btnPagar.Enabled = true;
                groupBox2.Enabled = true;
                MessageBox.Show("Cliente encontrado");
            }
            else
            {
                btnVerSaldo.Enabled = false;
                btnPagar.Enabled = false;
                groupBox2.Enabled = false;
                MessageBox.Show("Cliente no existe");
            }
        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbCUIT.Text);

            ClienteCuenta clienteActual = gestionVenta.BuscarCliente(cuit);
            if (clienteActual != null)
                MessageBox.Show("Saldo: " + clienteActual.SaldoCuenta);
            else
                MessageBox.Show("No se encontró cliente");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbCUIT.Text);

            ClienteCuenta clienteActual = gestionVenta.BuscarCliente(cuit);
            if (clienteActual != null)
            {
                Pedido paraPagar = clienteActual.RetirarPedido();
                if (paraPagar != null)
                {
                    double monto = paraPagar.Valor;
                    clienteActual.AgregarPago(monto);
                    MessageBox.Show("Usted pagó: $" + monto);
                }
                else
                    MessageBox.Show("No tiene pagos por realizar");
            }
            else
                MessageBox.Show("No se encontró cliente");
        }

        private void btnSelectProd_Click(object sender, EventArgs e)
        {
            if (tbKilos.Text == "")
                MessageBox.Show("Coloque cantidad de kilos");
            else if (productoSeleccionado != null)
            {
                double kilos = Convert.ToDouble(tbKilos.Text);
                productoSeleccionado.CantidadKilos = kilos;
                lbElegidos.Items.Add(productoSeleccionado.Descripcion());
                seleccionados.Add(productoSeleccionado);
                tbKilos.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            FResumen vResumen = new FResumen();
            nroPedido++;

            Pedido pedidoNuevo = gestionVenta.GenerarPedido(nroPedido, seleccionados);
            if (!gestionVenta.SumarPedido(clienteActual, pedidoNuevo))
            {
                string tope = String.Format("{0:C}", clienteActual.Tope);
                MessageBox.Show($"Este pedido supera su tope ({tope})");
                lbElegidos.Items.Clear();
                seleccionados.Clear();
            }
            else if (seleccionados.Count == 0)
                MessageBox.Show("No hay productos seleccionados");
            else
            {
                string[] lineas = pedidoNuevo.VerResumen().Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                foreach (string linea in lineas)
                    vResumen.lbResumen.Items.Add(linea);
                vResumen.ShowDialog();
                lbElegidos.Items.Clear();
            }
            vResumen.Dispose();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado = gestionVenta.lista[cbProducto.SelectedIndex];
        }

        private void tbCUIT_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btnPagar.Enabled = false;
            btnVerSaldo.Enabled = false;
        }

        private void btnExpClient_Click(object sender, EventArgs e)
        {
            if (clienteActual != null)
            {
                string ruta = Application.StartupPath + "\\Cliente.csv";
                if(clienteActual.Escribir(ruta))
                {
                    MessageBox.Show("Guardado en la ruta: " + ruta);
                }

            }
            else
                MessageBox.Show("No ingresó ningun cliente");
        }
        private void btnExpPedidos_Click(object sender, EventArgs e)
        {
            if (clienteActual != null)
            {
                int errores = 0;
                string ruta = Application.StartupPath + "\\Pedido.csv";
                if (File.Exists(ruta))
                    File.Delete(ruta);
                foreach (Pedido pedido in clienteActual.listaPedidos)
                {
                    if(!pedido.Escribir(ruta)) errores++;
                }
                if (errores > 0)
                    MessageBox.Show(errores + " pedidos no puedieron cargarse");
                MessageBox.Show("Guardado en la ruta: " + ruta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            Random rnd = new Random();
            // Crear 5 productos Premium
            productos.Add(new Premium("Alimento Premium 1", 50, 70));
            productos.Add(new Premium("Alimento Premium 2", 55, 75));
            productos.Add(new Premium("Alimento Premium 3", 60, 80));
            productos.Add(new Premium("Alimento Premium 4", 65, 85));
            productos.Add(new Premium("Alimento Premium 5", 70, 90));

            // Crear 5 productos Clasico
            productos.Add(new Clasico(40, "Alimento Clasico 1"));
            productos.Add(new Clasico(42, "Alimento Clasico 2"));
            productos.Add(new Clasico(44, "Alimento Clasico 3"));
            productos.Add(new Clasico(46, "Alimento Clasico 4"));
            productos.Add(new Clasico(48, "Alimento Clasico 5"));

            foreach (var producto in productos)
            {
                producto.CantidadKilos = rnd.Next(1, 15);
                lbElegidos.Items.Add(producto.Descripcion());
                seleccionados.Add(producto);
            }
        }

        private void Leer(String archivo)
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    Producto producto;
                    string[] line = sr.ReadLine().Split(';');
                    if (line[3] == "P")
                        producto = new Premium(line[0], Convert.ToDouble(line[1]), Convert.ToDouble(line[2]));
                    else
                        producto = new Clasico(Convert.ToDouble(line[1]), line[0]);
                    gestionVenta.lista.Add(producto);
                    cbProducto.Items.Add(producto.Descripcion());
                }

                sr.Close();
                fs.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error al abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            if(vSeleccionArchivo.ShowDialog() == DialogResult.OK)
            {
                string archivo = vSeleccionArchivo.FileName;
                if (archivo != "")
                    Leer(archivo);
                else
                    MessageBox.Show("Nombre de archivo vacio","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

    }
}
