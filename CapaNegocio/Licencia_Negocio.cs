using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Licencia_Negocio
    {


        private static Licencias_Datos objLicen = new Licencias_Datos();

        public static void agregarLicencia(Licencia licen)
        {
            objLicen.agregarpermiso(licen);
        }

        //Aqui listo todo en cuanto a los departamento 
        public static List<Licencia> listarlicencia()
        {
          
                return objLicen.listarlicencia();
            
        }


        public static Licencia GetLicencia(int id)
        {

            return objLicen.GetLicencia(id);
            
        }



    }
}
