using System;
using System.Data;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public MainWindow()
        {
            InitializeComponent();
            FechaYhora();
        }

        private void FechaYhora()
        {
            string FFecha, FHora;
            FHora = String.Format("{0:hh:mm tt}", DateTime.Now);
            FFecha = String.Format("{0:yyyy/d/M}", DateTime.Now);
            TextBoxFecha.Text = FFecha;    
            TextBoxHora.Text =FHora;
        }

    }
}
