using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Cargo_Datos
    {

        public void Agregar_Cargos(Cargo puesto)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                db.Cargoes.Add(puesto);
                db.SaveChanges();
            }

        }

        //Aqui listo todo en cuanto a los departamento 
        public List<Cargo> ListarCargos()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Cargoes.ToList();
            }
        }


        public Cargo GetCargo(int id)
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Cargoes.Where(d => d.Id_DelCargo == id).FirstOrDefault();
            }
        }


        public void EditarCargo(Cargo puesto)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                var bd = db.Cargoes.Find(puesto.Id_DelCargo);
                bd.Nombre_Del_Cargo = puesto.Nombre_Del_Cargo;
                db.SaveChanges();

            }

        }

        public void EliminarCargo(int id)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                var puesto = db.Cargoes.Find(id);
                db.Cargoes.Remove(puesto);
                db.SaveChanges();
            }
        }


    }
}
