using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Ejercicio1
{
    internal class Reserva
    {
        public String? fechaEntrada { get; set; }

        public String? fechaSalida { get; set; }

        public String? tipoHabitacion { get; set; }

        public int precio { get; set; }

        public Reserva(string? fechaEntrada, string? fechaSalida, string? tipoHabitacion, int precio)
        {
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.tipoHabitacion = tipoHabitacion;
            this.precio = precio;
        }

        public String toString()
        {
            return "F.Entrada: " + fechaEntrada + ". F.Salida: " + fechaSalida + ". T.Habitacón: " + tipoHabitacion + ". Precio: " + precio + "€";
        }

    }
}
