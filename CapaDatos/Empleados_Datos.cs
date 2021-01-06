using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Empleados_Datos
    {
        public void Agregar_empleado(Empleado Emplea)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                db.Empleadoes.Add(Emplea);
                db.SaveChanges();
            }

        }

        //Aqui listo todo en cuanto a los departamento 
        public List<Empleado> ListarEmpleado()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Empleadoes.ToList();
            }
        }

        public Empleado GetEmpleado(int id)
        {
            using (var emplo = new RecursosHumanoEntities1())
            {
                return emplo.Empleadoes.Where(d => d.iD == id).FirstOrDefault();
            }
        }



        public void EditarEmpleado(Empleado emple)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                var bd = db.Empleadoes.Find(emple.iD);
                bd.Codigo_De_Empleado = emple.Codigo_De_Empleado;
                bd.Nombre = emple.Nombre;
                bd.Apellido = emple.Apellido;
                bd.Telefono = emple.Telefono;
                bd.Salary = emple.Salary;
                bd.Fechadeingreso = emple.Fechadeingreso;
                bd.cargos = emple.cargos;
                bd.Departamento = emple.Departamento;
                bd.Estatus = emple.Estatus;

                db.SaveChanges();

            }

        }


        public void EliminarEmpleado(int id)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                var Empleado = db.Empleadoes.Find(id);
                db.Empleadoes.Remove(Empleado);
                db.SaveChanges();

            }
        }


    }
}
