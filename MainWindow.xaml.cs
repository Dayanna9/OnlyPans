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

namespace ParcialOneKaren
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           string nombreUsuario =  txt_usuario.Text;
           string contrasena = txt_contrasena.Text;
           
            Usuario admin = new Usuario("admin", "1234");
            Usuario vendedor = new Usuario("vendedor", "4321");
            MessageBox.Show(vendedor.contrasena);
            if (nombreUsuario == "admin" /*admin.nombre_usuario*/ && contrasena == /*admin.contrasena*/ "1234")
            {
                //redireccionar al panel admin
            }else if (nombreUsuario == "vendedor"/*vendedor.nombre_usuario*/ && contrasena == /*vendedor.contrasena*/ "4231")
            {
                //Redireccionar al panel vendedor
                VistaVendedor win2 = new VistaVendedor();
                win2.Show();
            }
            else
            {
                //Mensaje de error, porque los datos no coinciden con usuarios registrados.
            }
        }
    }
}
