using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{

    public class Departamento_Datos
    {


        public void AgregarDepartamento(Departamento depart)
        {
            using(var db = new RecursosHumanoEntities1())
            {
                db.Departamentos.Add(depart);
                db.SaveChanges();
            }


        }



        //Aqui listo todo en cuanto a los departamento 
        public List<Departamento> ListarDepartamento()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Departamentos.ToList();
            }
        }


        public Departamento GetDepartamento(int id)
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Departamentos.Where(d => d.Departamento_id == id).FirstOrDefault();
            }
        }


        public void Editar(Departamento depart)
        {
            using (var db = new RecursosHumanoEntities1() )
            {
                var bd = db.Departamentos.Find(depart.Departamento_id);
                bd.Codigo_Del_Departamento = depart.Codigo_Del_Departamento;
                bd.Nombre_Del_Departamento = depart.Nombre_Del_Departamento;
                db.SaveChanges();

            }

        }

        public void Eliminar(int id)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                var departamento = db.Departamentos.Find(id);
                db.Departamentos.Remove(departamento);
                db.SaveChanges();
            }
        }

    }
}
