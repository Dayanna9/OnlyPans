using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialOneKaren
{
    class Pan
    {
        string tipoPan;
        int cantidad;
        float precio;

        public string TipoPan { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public Pan(string tipoPan, int cantidad, float precio)
        {
            TipoPan = tipoPan;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
