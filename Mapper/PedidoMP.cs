using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Datos;
using Entidades;

namespace Mapper
{
    public class PedidoMP
    {

        Acceder Ac = new Acceder();

        public void grabar_ped(Pedido P, Cliente C)
        {

            List<SqlParameter> Parametros_pedido = new List<SqlParameter>();
            SqlParameter P1 = new SqlParameter();
            P1.SqlDbType = SqlDbType.Int;
            P1.ParameterName = "@Nrocliente";
            P1.Value = C.Nro_cliente;
            Parametros_pedido.Add(P1);

            Ac.Modificar("Agregar_pedido", Parametros_pedido);


            foreach (Panificados Pa in P.retorna_lista_panificados())   /// agrego a la tabla DETALLE_PEDIDO
            {
                List<SqlParameter> Parametros_detalle = new List<SqlParameter>();

                SqlParameter P2 = new SqlParameter();
                P2.SqlDbType = SqlDbType.VarChar;
                P2.ParameterName = "@desc";
                P2.Value = Pa.Descripcion;
                Parametros_detalle.Add(P2);


                SqlParameter P3 = new SqlParameter();
                P3.SqlDbType = SqlDbType.Int;
                P3.ParameterName = "@uni";
                P3.Value = Pa.Unidades;
                Parametros_detalle.Add(P3);

                SqlParameter P4 = new SqlParameter();
                P4.SqlDbType = SqlDbType.Int;
                P4.ParameterName = "@nrolote";
                P4.Value = Pa.Nro_lote;
                Parametros_detalle.Add(P4);


                Ac.Modificar("Agregar_detalle_pedido", Parametros_detalle);

            }

        }

        public List<Panificados> retorna_pedido_detalle(Pedido pe)
        {
            List<Panificados> Lista_pedidos = new List<Panificados>();
            List<SqlParameter> Parametros = new List<SqlParameter>();

            SqlParameter P1 = new SqlParameter();
            P1.SqlDbType = SqlDbType.Int;
            P1.ParameterName = "@nropedido";
            P1.Value = pe.Nro_pedido;
            Parametros.Add(P1);

            DataSet DS = Ac.Leer("Mostrar_pedido_cliente", Parametros);

            foreach (DataRow D in DS.Tables[0].Rows)
            {
                if (String.Compare(Convert.ToString(D[0]), "Pan hamburguesa comun") == 0)
                {
                    Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun();
                    Phc.Unidades = Convert.ToInt32(D[1]);
                    Phc.Nro_lote = Convert.ToInt32(D[3]);
                    Phc.Peso = 200;
                    Lista_pedidos.Add(Phc);
                }

                if (String.Compare(Convert.ToString(D[0]), "Pan hamburguesa maxi") == 0)
                {
                    Pan_hamburguesa_maxi Pmm = new Pan_hamburguesa_maxi();
                    Pmm.Unidades = Convert.ToInt32(D[1]);
                    Pmm.Nro_lote = Convert.ToInt32(D[3]);
                    Pmm.Peso = 320;
                    Lista_pedidos.Add(Pmm);
                }

                if (String.Compare(Convert.ToString(D[0]), "Pan lactal chico") == 0)
                {
                    Pan_lactal_chico Plc = new Pan_lactal_chico();
                    Plc.Unidades = Convert.ToInt32(D[1]);
                    Plc.Nro_lote = Convert.ToInt32(D[3]);
                    Plc.Peso = 300;
                    Lista_pedidos.Add(Plc);
                }
                if (String.Compare(Convert.ToString(D[0]), "Pan lactal grande") == 0)
                {
                    Pan_lactal_grande Plc = new Pan_lactal_grande();
                    Plc.Unidades = Convert.ToInt32(D[1]);
                    Plc.Nro_lote = Convert.ToInt32(D[3]);
                    Plc.Peso = 600;
                    Lista_pedidos.Add(Plc);
                }

                if (String.Compare(Convert.ToString(D[0]), "Pan pancho chico") == 0)
                {
                    Pan_pancho_chico Ppc = new Pan_pancho_chico();
                    Ppc.Unidades = Convert.ToInt32(D[1]);
                    Ppc.Nro_lote = Convert.ToInt32(D[3]);
                    Ppc.Peso = 230;
                    Lista_pedidos.Add(Ppc);
                }

                if (String.Compare(Convert.ToString(D[0]), "Pan pancho maxi") == 0)
                {
                    Pan_pancho_maxi Ppm = new Pan_pancho_maxi();
                    Ppm.Unidades = Convert.ToInt32(D[1]);
                    Ppm.Nro_lote = Convert.ToInt32(D[3]);
                    Ppm.Peso = 350;
                    Lista_pedidos.Add(Ppm);
                }

            }

            return Lista_pedidos;

        }
        public List<Pedido> obtener_pedidos_cliente(Cliente Cl) {

            List<Pedido> Lista_pedido = new List<Pedido>();
            List<SqlParameter> Parametros = new List<SqlParameter>();
            SqlParameter P1 = new SqlParameter();
            P1.SqlDbType = SqlDbType.Int;
            P1.ParameterName = "@nrocliente";
            P1.Value = Cl.Nro_cliente;
            Parametros.Add(P1);
            
            DataSet DS = Ac.Leer("Listar_pedidos", Parametros);
            foreach (DataRow D in DS.Tables[0].Rows) {

                Pedido Pe = new Pedido();
                Pe.Nro_pedido = Convert.ToInt32(D[1]);
                Lista_pedido.Add(Pe);
            }

            return Lista_pedido;


        }
        


    }
}
