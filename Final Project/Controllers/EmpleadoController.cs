using CapaEntidad;
using CapaNegocio;
using Final_Project.Models.ViewBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            var Lista_Empleado = Empleado_Negocio.ListarEmpleado();

            return View(Lista_Empleado);

        }
        //Crear Empleado
        public ActionResult Agregar_Empleado()
        {
            List<Departamento> DEPARTMETN = Departamento_Negocio.ListarDepartamento();
            List<SelectListItem> listaDepartamento = DEPARTMETN.ConvertAll( e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre_Del_Departamento.ToString(),
                    Selected = false
                };
            });


            List<Cargo> puestos = Cargos_Negocio.ListarCargos();
            List<SelectListItem> Lispuestos = puestos.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre_Del_Cargo.ToString(),
                    Selected = false
                };
            });



            ViewBag.items = listaDepartamento;
            ViewBag.cargos = Lispuestos;
            ViewBag.tipos = opciones();
            return View();

        }

        public List<SelectListItem> opciones()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "True",
                    Value = "True"
                },
                new SelectListItem()
                {
                    Text = "False",
                    Value = "False"
                },
                
            };
        }


        //Crear Empleado httpost
        [HttpPost]
        public ActionResult Agregar_Empleado(Empleado emple)
        {
            {

                try
                {
                    emple.Estatus = true;
                    Empleado_Negocio.Agregar_empleado(emple);
                    return RedirectToAction("Empleado");

                }
                catch (Exception x)
                {

                    ModelState.AddModelError("Error", x.Message);
                    return View(emple);
                }
            }
        }
        //Editar empleado 
        public ActionResult EditarEmpleado(int id)
        {
            var emple = Empleado_Negocio.GetEmpleado(id);


            List<Departamento> DEPARTMETN = Departamento_Negocio.ListarDepartamento();
            List<SelectListItem> listaDepartamento = DEPARTMETN.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre_Del_Departamento.ToString(),
                    Selected = false
                };
            });


            List<Cargo> puestos = Cargos_Negocio.ListarCargos();
            List<SelectListItem> Lispuestos = puestos.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre_Del_Cargo.ToString(),
                    Selected = false
                };
            });



            ViewBag.items = listaDepartamento;
            ViewBag.cargos = Lispuestos;

            return View();

            
        }
        //Ennviar Departamento 
        [HttpPost]
        public ActionResult EditarEmpleado(Empleado emple)
        {
            try
            {
                Empleado_Negocio.EditarEmpleado(emple);
                return RedirectToAction("Empleado");
            }
            catch (Exception x)
            {

                ModelState.AddModelError("Error", x.Message);
                return View(emple);
            }

        
        }
        //Aqui envio los cambio para editar departamento.
        [HttpPost]
        public ActionResult EliminarEmpleado(int id)
        {
            try
            {
                Empleado_Negocio.EliminarEmpleado(id);
                return Content("1");
            }
            catch (Exception x)
            {
                ModelState.AddModelError("", x.Message);
                return View();
            }
        }

    }

}
