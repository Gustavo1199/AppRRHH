using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class Negocio_Nomina

    {
        private static Datos_Nomina objeNomina = new Datos_Nomina();

        public static List<Nomina> ListaNomina()
        {
          return objeNomina.ListaNomina();
        }

        public static void agregarnomina(Nomina nom)
        {
            objeNomina.agregarnomina(nom);
        }

        public static void borarNomina(int id)
        {
            objeNomina.borarNomina(id);
        }


    }
}
