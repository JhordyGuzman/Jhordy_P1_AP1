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

namespace Jhordy_P1_AP1.UI.Registros
{
    public partial class rCiudades : Window
    {
        Ciudades ciudades = new Ciudades();

        public rCiudades()
        {
            InitializeComponent();
            this.DataContext = ciudades;

        }

        

        private void Limpiar(){
            this.ciudades = new Ciudades();
            this.DataContext = ciudades;
        }

        private bool Validar(){
            bool esValido = true;

            if (NombreTextBox.Text.Length == 0){   
                esValido = false;
                MessageBox.Show("Transaccion Fallida","Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e){
            var ciudades = CiudadesBLL.Buscar(Utilidades.ToInt(CiudadIdTextBox.Text));

            if (ciudades != null)
                this.ciudades = ciudades;
            else    
                this.ciudades = new Ciudades();

                this.DataContext = this.ciudades;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){
            Limpiar();
        }

     private void GuardarButton_Click(object sender, RoutedEventArgs e){
            
            if(!Validar()){
                return;
            }
            var paso = CiudadesBLL.Guardar(ciudades);

            if(paso){
                Limpiar();
                MessageBox.Show("Transaccion exitosa!" , "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("Transaccion Fallida", "Fallo",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){
            if (CiudadesBLL.Eliminar(Utilidades.ToInt(CiudadIdTextBox.Text))){
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        
    }
}