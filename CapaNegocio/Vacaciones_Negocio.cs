using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
   public class Vacaciones_Negocio
    {

        private static Vacaciones_Datos objVaca = new Vacaciones_Datos();

        public static void agregarVacaciones(Vacione vaca)
        {
            objVaca.agregarVacaciones(vaca);

        }

        //Aqui listo todo en cuanto a los departamento 
        public static List<Vacione> listarvacaciones()
        { 
            return objVaca.listarvacaciones();
        }

        public static Vacione GetVacione(int id)
        {

            return objVaca.GetVacione(id);
            
        }


    }
}
