using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Permisos_Datos
    {

        public void agregarpermiso(Permiso permitir)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                db.Permisoes.Add(permitir);
                db.SaveChanges();
            }

        }

        //Aqui listo todo en cuanto a los departamento 
        public List<Permiso> listarpermiso()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Permisoes.ToList();
            }
        }


        public Permiso GetPermiso(int id)
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Permisoes.Where(d => d.id == id).FirstOrDefault();
            }
        }



    }
}
