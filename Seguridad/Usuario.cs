using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;




namespace Seguridad
{
    public class Usuario
    {

        public string Nombre_usuario { get; set; }
        private string Clave { get; set; }

        public Usuario(string pNombre_usuario, string pClave)
        {
            Nombre_usuario = pNombre_usuario;
            Clave = pClave;
        }
        public Usuario(string pNombre_usuario)
        { Nombre_usuario = pNombre_usuario; }
        public Usuario() { }
        
        public string obtener_clave() { return Clave; }
        public void guardar_clave(string c) { this.Clave = c; }
    }
}
