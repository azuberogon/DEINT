using Navegación_de_aitor.vistas;
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

namespace Navegación_de_aitor
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
        private void Boton_window1(object sender, RoutedEventArgs e) { 
            Window AbrirVentana1 = new Window();
            this.Close();
            AbrirVentana1.Show();
        }
        private void Boton_Window2(object sender, RoutedEventArgs e) {
            Window1 AbrirVentana2 = new Window1();
            this.Close();
            AbrirVentana2.Show();
        }
        private void Boton_salir(object sender, RoutedEventArgs e) {
            System.Windows.Application.Current.Shutdown();

        }
    }
}
