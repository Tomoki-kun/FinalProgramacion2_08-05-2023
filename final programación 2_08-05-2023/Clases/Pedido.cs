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
    internal class Pedido : ISavable
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
            this.Detalle = string.Format("\n\n{0, -20} {1, -10} {2, -10} {3, -10}\n", "Producto", "Peso", "PrecioU", "Precio");
            foreach (Producto p in lista)
            {
                total += p.Precio(p.CantidadKilos);
                this.Detalle += p.ToString();
            }
            Valor = total;
            FechaHora = DateTime.Now;
        }
        public string VerResumen()
        {
            return  $"Pedido Nro: {Nro}\n" +
                    $"Fecha: {FechaHora:dd/MM/yyyy} Hora: {FechaHora:HH:mm}\n" +
                    $"{Detalle}" +
                    $"\nTotal\t\t\t\t\t\t{Valor}";
        }

        public bool Escribir(string ruta)
        {
            bool guardado = false;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(this.Nro + ";" + this.FechaHora + ";" + this.Detalle + ";" + this.Valor); //ARREGLAR DETALLE
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
