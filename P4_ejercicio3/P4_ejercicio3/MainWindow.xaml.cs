using MahApps.Metro.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
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

using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace P4_ejercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cb_motor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cb_tipo.Items.Clear();
            cb_tipo.Text = "Tipos de vehículo";
            cb_tipo.IsEditable = true;
            cb_tipo.IsReadOnly = true;
            cb_tipo.IsEnabled = true;
            
            if (cb_motor.SelectedIndex==0)
            {
                cb_tipo.Items.Add("Familiar");
                cb_tipo.Items.Add("SUV");
                cb_tipo.Items.Add("Todo Terreno");
            }

            else if (cb_motor.SelectedIndex == 1)
            {
                cb_tipo.Items.Add("Familiar");
                cb_tipo.Items.Add("SUV");
                cb_tipo.Items.Add("Turismo");               
            }

            else
            {
                cb_tipo.Items.Add("Familiar");
                cb_tipo.Items.Add("Turismo");
            }
        }

        private void cb_tipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cb_modelos.Items.Clear();
            cb_modelos.Text = "Modelo";
            cb_modelos.IsEditable = true;
            cb_modelos.IsReadOnly = true;
            cb_modelos.IsEnabled = true;

            if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 0)
            {
                cb_modelos.Items.Add("Auris Touring");
            }
            else if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 1)
            {
                cb_modelos.Items.Add("CHR");
                cb_modelos.Items.Add("RAV4");
            }
            else if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 2)
            {
                cb_modelos.Items.Add("HIGHLANDER");
            }
            else if (cb_motor.SelectedIndex == 1 && cb_tipo.SelectedIndex == 0)
            {
                cb_modelos.Items.Add("Prius +");
            }
            else if (cb_motor.SelectedIndex == 1 && cb_tipo.SelectedIndex == 1)
            {
                cb_modelos.Items.Add("RAV4");
            }
            else if (cb_motor.SelectedIndex == 1 && cb_tipo.SelectedIndex == 2)
            {
                cb_modelos.Items.Add("Yaris");
            }
            else if (cb_motor.SelectedIndex == 2 && cb_tipo.SelectedIndex == 0)
            {
                cb_modelos.Items.Add("Auris Touring");
                cb_modelos.Items.Add("Prius +");
            }
            else
            {
                cb_modelos.Items.Add("Auris");
                cb_modelos.Items.Add("Yaris");
                cb_modelos.Items.Add("Prius");
            }
        }

        private void cb_model_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BitmapImage? imageSource = null;

            if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 0)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\auris touring.jfif",UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 1 && cb_modelos.SelectedIndex == 0)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\CHR.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 1 && cb_modelos.SelectedIndex == 1)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\RAV4.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 0 && cb_tipo.SelectedIndex == 2)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\highlander.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 1 && cb_tipo.SelectedIndex == 0)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\prius+.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 1 && cb_tipo.SelectedIndex == 1)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\RAV4.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 1 && cb_tipo.SelectedIndex == 2)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\yaris.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 2 && cb_tipo.SelectedIndex == 0 && cb_modelos.SelectedIndex == 0)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\auris touring.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 2 && cb_tipo.SelectedIndex == 0 && cb_modelos.SelectedIndex == 1)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\prius+.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 2 && cb_tipo.SelectedIndex == 1 && cb_modelos.SelectedIndex == 0)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\auris.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 2 && cb_tipo.SelectedIndex == 1 && cb_modelos.SelectedIndex == 1)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\yaris.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
            else if (cb_motor.SelectedIndex == 2 && cb_tipo.SelectedIndex == 1 && cb_modelos.SelectedIndex == 2)
            {
                imageSource = new BitmapImage(new Uri("imagenes\\prius.jfif", UriKind.Relative));
                im_imagen.Source = imageSource;
            }
        }
    }
}