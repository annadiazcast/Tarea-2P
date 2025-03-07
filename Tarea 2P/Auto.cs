using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2P
{
    internal class Auto //Ana Diaz
    {
        public Auto(string marca, string modelo, int año, int noPuertas, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            NoPuertas = noPuertas;
            Color = color;
        }
        public Auto() { }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int NoPuertas { get; set; }
        public string Color { get; set; }

    }
}
