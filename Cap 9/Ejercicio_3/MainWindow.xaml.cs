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

namespace Ejercicio_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public struct Mascota
        {
            string NombreD;
            string Telefono;
            string  Direccion;

            string NombreMascota;
            int EdadMascota;
            string Vacunas;


            public Mascota(string dNombre, string dTelefono, string dDireccion, string mNombre, int mEdad, string mVacunas )
            {
                NombreD = dNombre;
                Telefono = dTelefono;
                Direccion = dDireccion;
                NombreMascota = mNombre;
                EdadMascota = mEdad;
                Vacunas = mVacunas;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Datos Dueño \nNombre:{0}\n Telefono: {1}\n Direccion: {2} \n\n\n Datos Mascota \nNombre: {3}\n Edad: {4}\n Vacunas: {5} ", 
                NombreD, Telefono, Direccion, NombreMascota, EdadMascota, Vacunas);
                return sb.ToString();
            }
        }
        public MainWindow ()
        {
            InitializeComponent();
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            int Edadm = Convert.ToInt32(EdadTextBox.Text);
            Mascota mascota = new Mascota(NombreDTextBox.Text, TelefonoTextBox.Text, DireccionTextBox.Text, NombreMascotaTextBox.Text, Edadm, VacunasTextBox.Text);
           MessageBox.Show("mascota Guaradado", "Listo");
        }

        public void VerButton_Click(object sender, RoutedEventArgs e)
        {
            int Edadm = Convert.ToInt32(EdadTextBox.Text);
            Mascota mascota = new Mascota(NombreDTextBox.Text, TelefonoTextBox.Text, DireccionTextBox.Text, NombreMascotaTextBox.Text, Edadm, VacunasTextBox.Text);
            Listar.Items.Add(mascota);
        }

    }
}
