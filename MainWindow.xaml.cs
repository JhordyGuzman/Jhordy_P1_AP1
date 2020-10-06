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
using Jhordy_P1_AP1.UI.Consultas;
using Jhordy_P1_AP1.UI.Registros;

namespace Jhordy_P1_AP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrosCiudades_Click(object sender, RoutedEventArgs e)
        {
            rCiudades ventana = new rCiudades();
            ventana.Show();
        }

        private void ConsultasCiudades_Click(object sender, RoutedEventArgs e)
        {
            cCiudades ventana = new cCiudades();
            ventana.Show();
        }
    }
}
