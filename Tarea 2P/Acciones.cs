using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2P
{
    internal class Acciones //Ana Diaz
    {
        public List<Auto> listaautomoviles=new List<Auto>();
        Auto Autos = new Auto();


        public void AgregarAuto()
        {
            Console.WriteLine("Marca del auto");
            Autos.Marca=Console.ReadLine();
            Console.WriteLine("Modelo del auto");
            Autos.Modelo=Console.ReadLine();
            Console.WriteLine("Año del carro");
            Autos.Año=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de puertas");
            Autos.NoPuertas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Color del auto");
            Autos.Color=Console.ReadLine();

            listaautomoviles.Add(new Auto(Autos.Marca, Autos.Modelo, Autos.Año, Autos.NoPuertas, Autos.Color));

        }
        public void MostrarAutos()
        {
            foreach (var a in listaautomoviles)
            {
                Console.WriteLine("Marca: "+a.Marca);
                Console.WriteLine("Modelo: "+a.Modelo);
                Console.WriteLine("Año: "+a.Año);
                Console.WriteLine("Numero de puertas: "+a.NoPuertas);
                Console.WriteLine("Color: "+a.Color);
            }
        }
        public int ContarAutos()
        {
            return listaautomoviles.Count;
        }
        public void EliminarAutos(string NombreMarca)
        {
            var automovil = listaautomoviles.Find(y => y.Marca == NombreMarca);
            if (automovil == null)
                listaautomoviles.Remove(automovil);
            else
            {
                Console.WriteLine("No se encontro el automovil");
            }
        }
        public void ActualizarAutomoviles()
        {
            Console.WriteLine("Introduce la marca del automovil que quieres actualizar: "); //Pedir marca actual del auto a actualizar
            string marcaantigua=Console.ReadLine();
            
            var automovil=listaautomoviles.Find(y=>y.Marca == marcaantigua);//buscar el auto con la antigua marca
            if (automovil == null)
            {
                Console.WriteLine("Dame la nueva marca del auto");
                string nuevamarca=Console.ReadLine();
                Console.WriteLine("Dame el nuevo modelo del auto");
                string nuevomodelo=Console.ReadLine();
                Console.WriteLine("Dame el nuevo año del automovil");
                int nuevoaño=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame el nuevo no. de puertas del automovil");
                int nuevonopuertas=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame el nuevo color del automovil");
                string nuevocolor=Console.ReadLine();

                automovil.Marca = nuevamarca;
                automovil.Modelo = nuevomodelo;
                automovil.Año = nuevoaño;
                automovil.NoPuertas = nuevonopuertas;
                automovil.Color= nuevocolor;

                Console.WriteLine("Los datos se han actualizado");
            }
            else
            {
                Console.WriteLine("No se encontro la marca del automovil");
            }
        }
    }
}
