using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class SalidaEmplado_Negocio
    {

        private static SalidadeEmpleado_Datos ObjSalida = new SalidadeEmpleado_Datos();

        public static void agregarSalidaDeEmpleado(SalidaDeEmpleado salida)
        {
            ObjSalida.agregarSalidaDeEmpleado(salida);
        }


        public static SalidaDeEmpleado GetSalidaDeEmpleado(int id)
        {

            return ObjSalida.GetSalidaDeEmpleado(id);
        }


        public static List<SalidaDeEmpleado> listarsalida()
        {
            return ObjSalida.listarsalida();
        }


       /*
        public static void EditarEmpleado(Empleado emple)
        {
            ObjEmplado.EditarEmpleado(emple);
        }

     */


    }
}
