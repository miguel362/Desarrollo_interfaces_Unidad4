using MahApps.Metro.Controls;
using System;
using System.Collections;
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

namespace P4_Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        Vehiculo coche=new Vehiculo();

        public MainWindow()
        {
            InitializeComponent();
        }
    
        private void btn_config_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem producto;

            var resumen = new Window1();

            if (ch_lunas.IsChecked == true)
            {
                coche.setNombreProducto("lunas tintadas");
                coche.setValorProducto(1200);
                producto = new ListBoxItem();
                producto.Content = coche.getNombreProducto() + "\t\t\t" + coche.getValorProducto() + "€";
                resumen.lv_producto.Items.Add(producto);
                coche.setSuma(coche.getValorProducto());
            }
            if (ch_remolque.IsChecked == true)
            {
                coche.setNombreProducto("Accesorio para remolque");
                coche.setValorProducto(1000);
                producto = new ListBoxItem();
                producto.Content = coche.getNombreProducto() + "\t\t" + coche.getValorProducto() + "€"; 
                resumen.lv_producto.Items.Add(producto);
                coche.setSuma(coche.getValorProducto());
            }
            if (ch_pintura.IsChecked == true)
            {
                coche.setNombreProducto("Pintura Metalizada");
                coche.setValorProducto(2000);
                producto = new ListBoxItem();
                producto.Content = coche.getNombreProducto() + "\t\t" + coche.getValorProducto() + "€";
                resumen.lv_producto.Items.Add(producto);
                coche.setSuma(coche.getValorProducto());
            }
            if (ch_seguridad.IsChecked == true)
            {
                coche.setNombreProducto("Pack de seguridad");
                coche.setValorProducto(6000);
                producto = new ListBoxItem();
                producto.Content = coche.getNombreProducto() + "\t\t" + coche.getValorProducto() + "€";
                resumen.lv_producto.Items.Add(producto);
                coche.setSuma(coche.getValorProducto());
            }
            if (ch_deluxe.IsChecked == true)
            {
                coche.setNombreProducto("Pack Deluxe");
                coche.setValorProducto(5500);
                producto = new ListBoxItem();
                producto.Content = coche.getNombreProducto() + "\t\t\t" + coche.getValorProducto() + "€";
                resumen.lv_producto.Items.Add(producto);
                coche.setSuma(coche.getValorProducto());
            }
            resumen.lbl_muestra.Content = "Precio total: " + coche.getSuma() + "€";
            resumen.Show();
            this.Close();
        }

        private void ch_seguridad_Checked(object sender, RoutedEventArgs e)
        {
            ch_airbag.IsChecked = true;
            ch_colision.IsChecked = true;
            ch_carril.IsChecked = true;
        }

        private void ch_seguridad_Unchecked(object sender, RoutedEventArgs e)
        {
            if(ch_airbag.IsChecked == true && ch_colision.IsChecked == true && ch_carril.IsChecked == true)
            {
                ch_airbag.IsChecked = false;
                ch_colision.IsChecked = false;
                ch_carril.IsChecked = false;
            }
            
        }

        private void ch_deluxe_Checked(object sender, RoutedEventArgs e)
        {
            ch_espejo.IsChecked = true;
            ch_llantas.IsChecked = true;
        }

        private void ch_deluxe_Unchecked(object sender, RoutedEventArgs e)
        {
            if(ch_espejo.IsChecked == true && ch_llantas.IsChecked == true)
            {
                ch_espejo.IsChecked = false;
                ch_llantas.IsChecked = false;
            }
        }

        private void ch_airbags_Cheked(object sender, RoutedEventArgs e)
        {
            if(ch_colision.IsChecked == true && ch_carril.IsChecked == true)
            {
                ch_seguridad.IsChecked = true;
            }
        }

        private void ch_colision_Cheked(object sender, RoutedEventArgs e)
        {
            if (ch_airbag.IsChecked == true && ch_carril.IsChecked == true)
            {
                ch_seguridad.IsChecked = true;
            }
        }

        private void ch_carril_Cheked(object sender, RoutedEventArgs e)
        {
            if (ch_colision.IsChecked == true && ch_airbag.IsChecked == true)
            {
                ch_seguridad.IsChecked = true;
            }
        }

        private void ch_airbag_Unchecked(object sender, RoutedEventArgs e)
        {
            ch_seguridad.IsChecked = false;
        }

        private void ch_colision_Unchecked(object sender, RoutedEventArgs e)
        {
            ch_seguridad.IsChecked = false;
        }

        private void ch_carril_Unchecked(object sender, RoutedEventArgs e)
        {
            ch_seguridad.IsChecked = false;
        }

        private void ch_espejo_Checked(object sender, RoutedEventArgs e)
        {
            if (ch_llantas.IsChecked == true)
            {
                ch_deluxe.IsChecked = true;
            }
        }

        private void ch_espejo_Unchecked(object sender, RoutedEventArgs e)
        {
            if (ch_deluxe.IsChecked == true)
            {
                ch_deluxe.IsChecked = false;
            }
        }

        private void ch_llantas_Checked(object sender, RoutedEventArgs e)
        {
            if (ch_espejo.IsChecked == true)
            {
                ch_deluxe.IsChecked = true;
            }
        }

        private void ch_llantas_Unchecked(object sender, RoutedEventArgs e)
        {
            if (ch_deluxe.IsChecked == true)
            {
                ch_deluxe.IsChecked = false;
            }
        }
    }
}