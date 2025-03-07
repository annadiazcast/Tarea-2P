using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2P
{
    internal class Program //Ana Diaz
    {
        public enum Menu
        {
            Agregar=1,Mostrar,Contar,Eliminar,Actualizar,Salir
        }
        static void Main(string[] args)
        {
            Acciones Auto= new Acciones();
            while (true) 
            {
                switch (menu())
                {
                    case Menu.Agregar:
                        Auto.AgregarAuto();
                        break;
                    case Menu.Mostrar:
                        Auto.MostrarAutos();
                        break;
                    case Menu.Contar:
                        Console.WriteLine("El numero de autos es: "+Auto.ContarAutos());
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Que marca de auto quieres eliminar");
                        string marca=Console.ReadLine();
                        Auto.EliminarAutos(marca);
                        break;
                    case Menu.Actualizar:
                        Auto.ActualizarAutomoviles();
                        break;
                    case Menu.Salir:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Contar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Actualizar");
            Console.WriteLine("6. Salir");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
