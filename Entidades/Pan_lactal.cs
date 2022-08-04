using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pan_lactal_chico : Panificados
    {

        public Pan_lactal_chico(int pUnidades)
        {
            Peso = 300;
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_lactal_chico(int pNro_lote, int pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 300;
            Unidades = pUnidades;
            agregar_descripcion();
        }
        public Pan_lactal_chico() { agregar_descripcion(); }


        public override void agregar_descripcion() { this.Descripcion = "Pan lactal chico"; }



    }

    public class Pan_lactal_grande : Panificados
    {

        public Pan_lactal_grande(int pUnidades)
        {
            Peso = 600;
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_lactal_grande(int pNro_lote,int pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 600;
            Unidades = pUnidades;
            agregar_descripcion();
        }
        public Pan_lactal_grande() { agregar_descripcion(); }
        public override void agregar_descripcion() { this.Descripcion = "Pan lactal grande"; }

    }





}
