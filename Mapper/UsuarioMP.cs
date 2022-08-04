using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Collections;
using System.Data;
using Entidades;
using System.Data.SqlClient;
using Seguridad;

namespace Mapper
{
    public class UsuarioMP
    {
        Acceder Ac = new Acceder();


        public List<Usuario> obtener_lista_usu()
        {
            List<Usuario> Lista_usuarios = new List<Usuario>();
            DataSet Ds = Ac.Leer("Mostrar_usuarios", null);

            foreach (DataRow D in Ds.Tables[0].Rows)
            {
                Usuario Usu = new Usuario();
                Usu.Nombre_usuario = Convert.ToString(D[0]);
                Usu.guardar_clave(Convert.ToString(D[1]));
                Lista_usuarios.Add(Usu);
            }

            return Lista_usuarios;

        }

        public bool checkear_usuario_nom(string nombre)
        {

            List<SqlParameter> Parametro = new List<SqlParameter>();
            SqlParameter P = new SqlParameter();
            P.ParameterName = "@nom";
            P.Value = nombre;
            P.SqlDbType = SqlDbType.VarChar;
            Parametro.Add(P);

            DataSet DS;

            DS = Ac.Leer("Mostrar_usuario_nombre", Parametro);
            if (DS.Tables[0].Rows.Count == 0)
            { return false; }                    /// si no existe usuario con ese nombre retorna false
            else
            { return true; }           




        }




        public int alta_usuario(Usuario U)
        {


            List<SqlParameter> Parametros = new List<SqlParameter>();
            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@nom";
            P1.Value = U.Nombre_usuario;
            P1.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P1);


            DataSet DS = Ac.Leer("Mostrar_usuario_nombre", Parametros);   // checkeo si existe ese nombre de usuario
            if (DS.Tables[0].Rows.Count > 0)

            { return 1; }

            else                                           // si no existe lo agrego
            {
                Encriptacion E = new Encriptacion();
                U.guardar_clave(E.Encriptar(U.obtener_clave()));                // encripto la clave

                SqlParameter P2 = new SqlParameter();
                P2.ParameterName = "@con";
                P2.Value = U.obtener_clave();
                P2.SqlDbType = SqlDbType.VarChar;
                Parametros.Add(P2);

                Ac.Modificar("Agregar_usuario", Parametros);
                return 0;
            }
        }

        public void baja_usu(string U)
        {
            List<SqlParameter> Parametro = new List<SqlParameter>();
            SqlParameter P = new SqlParameter();


            P.ParameterName = "@nom";
            P.Value = U;
            P.SqlDbType = SqlDbType.VarChar;
            Parametro.Add(P);


            Ac.Modificar("Borrar_usuario", Parametro);


        }

        public void checkear_usu() { }


        public List<string> validar(string usu)
        {
            string usuario;
            string pass;


            List<string> array_cred = new List<string>();
            List<SqlParameter> Parametros = new List<SqlParameter>();

            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@usu";
            P1.Value = usu;
            P1.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P1);






            DataSet DS = Ac.Leer("Buscar_usuario", Parametros);

            if (DS.Tables[0].Rows.Count == 0)
            { return array_cred; }             // si no existe el usuario devuelvo una lista vacia

            else                             // existe el usuario
            {

                foreach (DataRow D in DS.Tables[0].Rows)

                {
                    usuario = Convert.ToString(D[0]);
                    pass = Convert.ToString(D[1]);
                    array_cred.Add(usuario);
                    array_cred.Add(pass);

                }


                return array_cred;
            }

        }

        public void modificar_usu(Usuario U, string usu_ant)
        {
            Encriptacion E = new Encriptacion();
            U.guardar_clave(E.Encriptar(U.obtener_clave()));
            List<SqlParameter> Parametros = new List<SqlParameter>();

            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@nom";
            P1.Value = U.Nombre_usuario;
            P1.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P1);

            SqlParameter P2 = new SqlParameter();
            P2.ParameterName = "@con";
            P2.Value = U.obtener_clave();
            P2.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P2);

            SqlParameter P3 = new SqlParameter();
            P3.ParameterName = "@nom_ant";
            P3.Value = usu_ant;
            P3.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P3);

            Ac.Modificar("Modificar_usuario", Parametros);

        }




    }
}