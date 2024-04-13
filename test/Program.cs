using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("10.000.000", "Juan", "Perez", new List<Auto>());

            Auto a1 = new Auto("ttt 874", "Peugeot", "Siena", "2001", 300000m);
            Auto a2 = new Auto("abc 221", "Peugeot", "Siena", "2001", 300000m);

            p1.ListaAutos.Add(a1);
            p1.ListaAutos.Add(a2);
            p1.Lista_de_autos(p1.ListaAutos);
            p1.Cantidad_de_Autos(p1.ListaAutos);


                        //foreach (var item in p1.ListaAutos)
            //{
            //    Console.WriteLine($"{item.Patente}");
            //}

            //Console.WriteLine(p1.ListaAutos);

            Console.ReadLine();
        }

        
    }
}
