using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using Entidades;

namespace BLL
{
    public class ClienteBLL
    {
        public MapCliente Mp = new MapCliente();

        public List<Cliente> Retorna_cliente()
        {
            return Mp.retorna_lista_cliente();

        }


        public void graba_cliente(Cliente C) { Mp.g_cliente(C); }

        public void borra_cliente(int Nro_cli) {

            Mp.b_cliente(Nro_cli);
        }
    
        public void modifica_cliente(Cliente C) { Mp.Modificar(C); }
    
    
    }
}
