using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Cargos_Negocio
    {
 
        private static Cargo_Datos CargoObjeto = new Cargo_Datos();

        public static void Agregar_Cargos(Cargo puesto)
        {
            CargoObjeto.Agregar_Cargos(puesto);
        }

        //Aqui listo todo en cuanto a los departamento 
        public static List<Cargo> ListarCargos()
        {

            return CargoObjeto.ListarCargos();
        }

        public static Cargo GetCargo(int id)
        {

            return CargoObjeto.GetCargo(id);
        }

        public static void EditarCargo(Cargo puesto)
        {
            CargoObjeto.EditarCargo(puesto);
        }

        public static void EliminarCargo(int id)
        {
            CargoObjeto.EliminarCargo(id);

        }

    }
}
