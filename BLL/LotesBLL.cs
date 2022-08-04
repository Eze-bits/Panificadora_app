using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;

namespace BLL
{
    public class LotesBLL
    {
        LoteMP Ml = new LoteMP();
        public bool checkear_lote(Lote L) { return Ml.checkear_l(L); }

        public void graba_lote(Lote L) { Ml.graba_l(L); }
        public void modificar_stock(Lote L) { Ml.Modificar(L); }

        public bool retorna_lotes_cargados() { return Ml.checkear_ltodos(); }

        public List<Lote> retorna_listado_de_lotes()
        {
            return Ml.retorna_listado_de_lot();
        }

        public void baja_detalle_en_lote( Lote L)
        {

            Ml.baja_detalle_en_l(L);
        }

        public void borrar_productos_lote(Panificados p) { Ml.borrar_prod(p); }
        public void agregar_productos_lote(Lote L) { Ml.agregar_prod(L); }
        public void actualizar_stock_lotes(List<Lote> Lista_lotes) { Ml.actualizar_stock_lot(Lista_lotes); }
   
    
    }
}
