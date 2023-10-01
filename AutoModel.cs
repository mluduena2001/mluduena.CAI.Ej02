using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mluduena.CAI.Ej02
{
    internal class AutoModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public float Precio { get; set; }

        public AutoModel() { }

        public AutoModel(string marca, string modelo, int año, float precio) 
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
        }

    }

  
}
