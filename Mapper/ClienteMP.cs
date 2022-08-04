using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Abstraccion;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace Mapper
{
    public class MapCliente:IGestor<Cliente>
    {
        Acceder Ac = new Acceder();
        public List<Cliente> retorna_lista_cliente()
        {
            List<Cliente> Cl = new List<Cliente>();

            DataSet DS = Ac.Leer("Mostrar_clientes", null);
            foreach (DataRow D in DS.Tables[0].Rows)
            {
                Cliente C = new Cliente();
                C.Nro_cliente = Convert.ToInt32(D[0]);
                C.Nombre = Convert.ToString(D[1]);
                C.Apellido = Convert.ToString(D[2]);
                C.Email = Convert.ToString(D[3]);
                C.Calle = Convert.ToString(D[4]);
                C.Nro_casa = Convert.ToInt32(D[5]);
                C.Localidad = Convert.ToString(D[6]);
                C.Telefono_particular = Convert.ToInt32(D[7]);
                C.DNI = Convert.ToInt32(D[8]);

                Cl.Add(C);
            }

            return Cl;
        }

        public void g_cliente(Cliente C)                            /// graba nuevo cliente
        {

  List<SqlParameter> Parametros = new List<SqlParameter>();


            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@nom";
            P1.Value = C.Nombre;
            P1.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P1);

            SqlParameter P2 = new SqlParameter();
            P2.ParameterName = "@ape";
            P2.Value = C.Apellido;
            P2.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P2);

            SqlParameter P3 = new SqlParameter();
            P3.ParameterName = "@email";
            P3.Value = C.Email;
            P3.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P3);

            SqlParameter P4 = new SqlParameter();
            P4.ParameterName = "@calle";
            P4.Value = C.Calle;
            P4.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P4);

            SqlParameter P5 = new SqlParameter();
            P5.ParameterName = "@nrocasa";
            P5.Value = C.Nro_casa;
            P5.SqlDbType = SqlDbType.Int;
            Parametros.Add(P5);

            SqlParameter P6 = new SqlParameter();
            P6.ParameterName = "@loc";
            P6.Value = C.Localidad;
            P6.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P6);

            SqlParameter P7 = new SqlParameter();
            P7.ParameterName = "@tel";
            P7.Value = C.Telefono_particular;
            P7.SqlDbType = SqlDbType.Int;
            Parametros.Add(P7);

            SqlParameter P8 = new SqlParameter();
            P8.ParameterName = "@dni";
            P8.Value = C.DNI;
            P8.SqlDbType = SqlDbType.Int;
            Parametros.Add(P8);

            Ac.Modificar("Agregar_cliente", Parametros);
        }

        public void b_cliente(int Nro_cliente)
        {
            List<SqlParameter> Parametro = new List<SqlParameter>();

            SqlParameter P = new SqlParameter();
            P.ParameterName = "@nrocliente";
            P.Value = Nro_cliente;
            P.SqlDbType = SqlDbType.Int;
            Parametro.Add(P);

            Ac.Modificar("Borrar_cliente", Parametro);

        }

        public void Modificar(Cliente C)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();

            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@nom";
            P1.Value = C.Nombre;
            P1.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P1);

            SqlParameter P2 = new SqlParameter();
            P2.ParameterName = "@ape";
            P2.Value = C.Apellido;
            P2.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P2);

            SqlParameter P3 = new SqlParameter();
            P3.ParameterName = "@email";
            P3.Value = C.Email;
            P3.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P3);

            SqlParameter P4 = new SqlParameter();
            P4.ParameterName = "@calle";
            P4.Value = C.Calle;
            P4.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P4);

            SqlParameter P5 = new SqlParameter();
            P5.ParameterName = "@nrocasa";
            P5.Value = C.Nro_casa;
            P5.SqlDbType = SqlDbType.Int;
            Parametros.Add(P5);

            SqlParameter P6 = new SqlParameter();
            P6.ParameterName = "@loc";
            P6.Value = C.Localidad;
            P6.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P6);

            SqlParameter P7 = new SqlParameter();
            P7.ParameterName = "@tel";
            P7.Value = C.Telefono_particular;
            P7.SqlDbType = SqlDbType.Int;
            Parametros.Add(P7);

            SqlParameter P8 = new SqlParameter();
            P8.ParameterName = "@dni";
            P8.Value = C.DNI;
            P8.SqlDbType = SqlDbType.VarChar;
            Parametros.Add(P8);

            SqlParameter P9 = new SqlParameter();
            P9.ParameterName = "@nrocliente";
            P9.Value = C.Nro_cliente;
            P9.SqlDbType = SqlDbType.Int;
            Parametros.Add(P9);



            Ac.Modificar("Modificar_cliente", Parametros);


        }



    }
}
