using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
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

namespace P4_Ejercicio1
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


        private int precioFinal = 0;

        private void aniadirReserva(object sender, RoutedEventArgs e)
        {
            if(dpCalendarioSalida.SelectedDate != null)
            {
                Reserva? unaReserva = null;
                int precioHabitacion = 0;
                //Calculo la diferencia de días para calcular el precio
                DateTime fechaUno = Convert.ToDateTime(dpCalendarioEntrada.SelectedDate);
                DateTime fechaDos = Convert.ToDateTime(dpCalendarioSalida.SelectedDate);
                TimeSpan difFechas = fechaDos - fechaUno;
                int dias = difFechas.Days;
                if (rbDoble.IsChecked == true)
                {
                    precioHabitacion = 100 * dias;
                    unaReserva = new Reserva(dpCalendarioEntrada.SelectedDate.ToString(), dpCalendarioSalida.SelectedDate.ToString(), "Doble", precioHabitacion);
                }
                else if (rbFamiliar.IsChecked == true)
                {
                    precioHabitacion = 200 * dias;
                    unaReserva = new Reserva(dpCalendarioEntrada.SelectedDate.ToString(), dpCalendarioSalida.SelectedDate.ToString(), "Familiar", precioHabitacion);
                }
                else if (rbSuite.IsChecked == true)
                {
                    precioHabitacion = 300 * dias;
                    unaReserva = new Reserva(dpCalendarioEntrada.SelectedDate.ToString(), dpCalendarioSalida.SelectedDate.ToString(), "Suite", precioHabitacion);
                }


                precioFinal += precioHabitacion;
                listBox.Items.Insert(0,unaReserva);
                txPrecioFinal.Text = "Precio total de la reserva: " + precioFinal + "€";
            }
            
        }

        private void habilitarCalendario(object sender, RoutedEventArgs e)
        {
            dpCalendarioEntrada.IsEnabled = true;
            dpCalendarioEntrada.BlackoutDates.AddDatesInPast();
        }

        private void dpCalendarioEntrada_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dpCalendarioSalida.IsEnabled = true;
            dpCalendarioSalida.SelectedDate = dpCalendarioEntrada.SelectedDate;
            dpCalendarioSalida.DisplayDateStart = dpCalendarioSalida.SelectedDate;
        }

        private void borrar(object sender, RoutedEventArgs e)
        {
            txPrecioFinal.Text = "";
            precioFinal = 0;
            listBox.ItemsSource = null;

        }
    }
}
