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
using Jhordy_P1_AP1.Entidades;
using Jhordy_P1_AP1.DAL;
using Jhordy_P1_AP1.BLL;

namespace Jhordy_P1_AP1.UI.Consultas
{
    public partial class cCiudades : Window
    {
        Ciudades ciudades = new Ciudades();

        public cCiudades()
        {
            InitializeComponent();
            

        }

        

    }
}