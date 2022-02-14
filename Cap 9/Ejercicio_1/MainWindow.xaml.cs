using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct Productos
        {
            int ProductoId;
            string Descripcion;
            int PrecioProducto;

            public Productos(int pProductoId, string pDescripcion,int pPrecio)
            {
                ProductoId = pProductoId;
                Descripcion = pDescripcion;
                PrecioProducto = pPrecio;
            }

            public override string ToString()
            {
                StringBuilder StringBuilder = new StringBuilder();
                StringBuilder.AppendFormat("ProductoID: {0}\n Descripcion:{1}\n Precio: {2}", 
                ProductoId, Descripcion, PrecioProducto);
                return StringBuilder.ToString();
            }
        }
        public MainWindow ()
        {
            InitializeComponent();
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            int ProductoId = Convert.ToInt32(IdTextBox.Text);
            int Precioproducto = Convert.ToInt32(PrecioTextBox.Text);
            Productos producto = new Productos(ProductoId,DescripcionTextBox.Text,Precioproducto);
           MessageBox.Show("Producto Guaradado", "Listo");
        }

        public void VerButton_Click(object sender, RoutedEventArgs e)
        {
            int ProductoId = Convert.ToInt32(IdTextBox.Text);
            int Precioproducto = Convert.ToInt32(PrecioTextBox.Text);
            Productos producto = new Productos(ProductoId,DescripcionTextBox.Text,Precioproducto);
            Listar.Items.Add(producto);
        }

        public void LimpiarButton_Click(Object sender, RoutedEventArgs e )
        {
            IdTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;

            Listar.Items.Clear();
        }
    }
}
