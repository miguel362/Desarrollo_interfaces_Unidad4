using System.Windows;
using System.Windows.Input;

namespace P4_ejercicio4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nombre, apellido, dni, direccion, poblacion, provincia, miembros, renta, metros;

        private void btn_tramite_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tramite Realizado.");
            System.Windows.Application.Current.Shutdown();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btn_tramite.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_tramite.IsEnabled = false;
        }


        private void pestaña3_GotFocus(object sender, RoutedEventArgs e)
        {
            lbl_resumen.Content = "Resumen " + "\n" + "\n"
                            + "Nombre: " + nombre + "\n"
                            + "Apellido: " + apellido + "\n"
                            + "DNI: " + dni + "\n"
                            + "direccion: " + direccion + "\n"
                            + "poblacion: " + poblacion + "\n"
                            + "provincia: " + provincia + "\n"
                            + "miembros familiares: " + miembros + "\n"
                            + "renta: " + renta + "€\n"
                            + "metros: " + metros + " metros cuadrados";
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void pestaña1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_nombre.Text.Length > 0 && txt_apellido.Text.Length > 0 && txt_dni.Text.Length > 0 && txt_direccion.Text.Length > 0 && txt_poblacion.Text.Length > 0 && txt_provincia.Text.Length > 0)
            {
                pestaña2.IsEnabled = true;
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                dni = txt_dni.Text;
                direccion = txt_direccion.Text;
                poblacion = txt_poblacion.Text;
                provincia = txt_provincia.Text;
            } 
        }

        private void pestaña2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_miembros.Text.Length > 0 && txt_renta.Text.Length > 0 && txt_catastro.Text.Length > 0 && txt_metros.Text.Length > 0)
            {
                pestaña3.IsEnabled = true;
                miembros = txt_miembros.Text;
                renta = txt_renta.Text;
                metros = txt_metros.Text;
            }
        }
    }
}
