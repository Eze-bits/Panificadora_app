using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using Entidades;
using Seguridad;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioMP usuMP=new UsuarioMP();

        public int alta_usuario(Usuario U) { return usuMP.alta_usuario(U); }
        public void modificar_usuario(Usuario U,string user) { usuMP.modificar_usu(U, user); }
        public List<Usuario> obtener_lista_usuarios() { return usuMP.obtener_lista_usu(); }
        public void baja_usuario(string U) { usuMP.baja_usu(U); }
        public List<string> validar_usuario(string usu) { return usuMP.validar(usu); }

        public bool checkear_usuario_nombre(string nombre) { return usuMP.checkear_usuario_nom(nombre); }

    }
}
