using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private Auto unAuto { get; set; }   
        public List<Auto> ListaAutos { get; set; }

        public Persona() { }
        public Persona(string dNI, string nombre, string apellido, List<Auto> listaAutos)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            this.ListaAutos = listaAutos;
        }

        public void Lista_de_autos(List<Auto> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Patente}");
            }
            //foreach (var item in p1.ListaAutos)
            //{
            //    Console.WriteLine($"{item.Patente}");
            //}
        }

        public void Cantidad_de_Autos(List<Auto> lista)
        {
            int cantidad = 0;
            foreach(var item in lista)
            {
                cantidad++;
            }
            Console.WriteLine($"Cantidad de autos: {cantidad}");
        }
        ~Persona() { Console.WriteLine("EL objeto fue eliminado"); }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
