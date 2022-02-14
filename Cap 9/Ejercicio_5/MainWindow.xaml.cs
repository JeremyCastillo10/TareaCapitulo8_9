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

namespace Ejercicio_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Neumaticos 
        {
            TipoVerano , 
            TipoInvierno, 
            TipoDeportivo, 
            };
        public MainWindow()
        {
            InitializeComponent();
            TNeumaticos();
        }

        public void TNeumaticos()
        {
           int neumaticoD = (int)Neumaticos.TipoDeportivo;
           int neumativoV = (int)Neumaticos.TipoVerano;
           int neumativoINV = (int)Neumaticos.TipoInvierno;
           
           string mineumatico1 = "Tipo Deportivo " + neumaticoD;
           string mineumatico2 = "Tipo Verano " + neumativoV;
           string mineumatico3 = "Tipo Invierno " + neumativoINV;

           Listar.Items.Add(mineumatico1);
           Listar.Items.Add(mineumatico2);
           Listar.Items.Add(mineumatico3);
            
        }
    }
}
