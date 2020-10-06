using System;
using System.Collections.Generic;
using System.Windows;
using Jhordy_P1_AP1.Entidades;
using Jhordy_P1_AP1.BLL;

namespace Jhordy_P1_AP1.UI.Consultas
{
    public partial class cCiudades : Window
    {
        public cCiudades()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Ciudades>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch(FiltroComboBox.SelectedIndex)
                {
                    case 1:{
                        listado = CiudadesBLL.GetList(e => e.CiudadId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    }
                    case 2:{
                        listado= CiudadesBLL.GetList(e => e.Nombre.Contains(CriterioTextBox.Text, StringComparison.OrdinalIgnoreCase));
                        break;
                    }
                }
            }
            else
            {
                listado= CiudadesBLL.GetList(p => true);
            }
                Consulta.ItemsSource = null;
                Consulta.ItemsSource = listado;
            
        }
    }
}