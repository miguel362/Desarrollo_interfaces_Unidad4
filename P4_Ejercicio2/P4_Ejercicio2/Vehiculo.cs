using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Ejercicio2
{
    internal class Vehiculo
    {
       private string nombre_producto;
       private int valor_producto;
       private int suma = 0;

       public string getNombreProducto() { return nombre_producto; }
       public int getValorProducto() { return valor_producto; }

       public int getSuma() { return suma; }


       public void setNombreProducto(String nombre) { nombre_producto = nombre; }
       public void setValorProducto(int valor) { valor_producto = valor ; }

       public void setSuma(int valor) { suma += valor; }
    }
}
