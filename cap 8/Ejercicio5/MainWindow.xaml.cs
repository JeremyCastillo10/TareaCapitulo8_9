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

namespace Ejercicio5
{
    /// <summary>
    // Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OrdenarButton_Click(object sender, RoutedEventArgs e)
        {
            string[] cadenas = { Cadena1txt.Text, Cadena2txt.Text };

            IEnumerable<string> Ordenado =
            from cadena in cadenas
            orderby cadena 
            select cadena;
            foreach (string s in Ordenado)
            {
               Resultado.Items.Add(s);
            }
        }
    }
}
