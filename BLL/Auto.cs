using System;
using System.Collections.Generic;
using System.Globalization;
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

        public override string ToString()
        {
            NumberFormatInfo formato = new CultureInfo("es-AR").NumberFormat;
            formato.CurrencyGroupSeparator = ".";
            formato.NumberDecimalSeparator = ",";
            formato.CurrencySymbol = "$";

            return $"Patente{this.Patente}, Precio{this.Precio.ToString("C", formato)}";

        }
    }
}
