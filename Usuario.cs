using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialOneKaren
{
    class Usuario
    {
        public string nombre_usuario;
        public string contrasena;


        public string NombreUsuario { get; set; } 
        public string Contrasena { get; set; }

        public Usuario(string nombre_usuario, string contrasena)
        {
            NombreUsuario = nombre_usuario;
            Contrasena = contrasena;
        }
    }
}
