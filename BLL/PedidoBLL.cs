using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;

namespace BLL
{
    public class PedidoBLL
    {
        PedidoMP PeM = new PedidoMP();
        public void grabar_pedido(Pedido Pe,Cliente C) {

            PeM.grabar_ped(Pe, C);
        
        }
        
        public List<Panificados> obtener_pedido_detalle(Pedido Pe) { return PeM.retorna_pedido_detalle(Pe); }
        public List<Pedido> obtener_pedidos_cli(Cliente C) { return PeM.obtener_pedidos_cliente(C); }

    }
}
