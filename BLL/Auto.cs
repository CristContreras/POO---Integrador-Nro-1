using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        //private decimal precio;

        //public decimal Precio
        //{
        //    get { return precio; }
        //    set { precio = value; }
        //}

        public decimal Precio { get; set; }

        public Auto() { }

        public Auto(string patente, string marca, string modelo, string año, decimal precio)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
        }


    }
}
