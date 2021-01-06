using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class Permiso_Negocio
    {

        private static Permisos_Datos objPermiso = new Permisos_Datos();


        public static void agregarpermiso(Permiso permitir)
        {

            objPermiso.agregarpermiso(permitir);
        }

        //Aqui listo todo en cuanto a los departamento 
        public static List<Permiso> listarpermiso()
        {

            return objPermiso.listarpermiso();
            
        }


        public static Permiso GetPermiso(int id)
        {

            return objPermiso.GetPermiso(id);
            
        }



    }
}
