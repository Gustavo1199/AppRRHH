using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;

namespace Final_Project.Controllers
{
    public class ProcesosController : Controller
    {

        //Nomina
        public ActionResult Nomina()
        {
            var lista = Negocio_Nomina.ListaNomina();
            return View(lista);

        }

        [RequireHttps]
        public ActionResult CalcularNomina(Nomina nom)
        {

            decimal total = 0;
            foreach (var a in Empleado_Negocio.ListarEmpleado())
            {
                total += a.Salary;
            }

            nom.Mes = DateTime.Now.ToString("MMMM");
            nom.Ano = DateTime.Now.ToString("yyyy");
            nom.Monto_Total = total;
            Negocio_Nomina.agregarnomina(nom);



            return RedirectToAction("Nomina");

        }
        //Salida de empleado

        public ActionResult SalidaDeEmplado()
        {

            var lista = SalidaEmplado_Negocio.listarsalida();
            return View(lista);
        }

        public ActionResult agregarSalida()
        {

            List<Empleado> empleado = Empleado_Negocio.ListarEmpleado();
            List<SelectListItem> item = empleado.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    
                    Text = e.iD.ToString(),
                    Value = e.iD.ToString(),
                    Selected = false

                };
            });

            ViewBag.empleado = item;
            ViewBag.itemTipo = opciones();

            return View();
        }

        public List<SelectListItem> opciones()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Renuncia",
                    Value = "Renuncia"
                },
                new SelectListItem()
                {
                    Text = "Despido",
                    Value = "Despido"
                },
                new SelectListItem()
                {
                    Text = "Desahucio",
                    Value = "Desahucio"
                }
            };
        }

        [HttpPost]
        public ActionResult agregarSalida(SalidaDeEmpleado EmpleSalida)
        {
           // try
            //{
                EmpleSalida.Fecha_Salida = DateTime.Now.ToString("MMMM");
                SalidaEmplado_Negocio.agregarSalidaDeEmpleado(EmpleSalida);
                //Aqui esto es una prueba para inatibar un empleado
                return Redirect(Url.Content("~/Procesos/SalidaDeEmplado"));
           // }
            /*
            catch (Exception e)
            {
                ModelState.AddModelError("Ocurrio un error", e.Message);
                return View(EmpleSalida);
            }
            */
        }

        //Vacaciones
        public ActionResult ListarVacaciones()
        {
            var lista = Vacaciones_Negocio.listarvacaciones();
            return View(lista);
        }
        
        public ActionResult agregarVaciones()
        {
            List<Empleado> empleado = Empleado_Negocio.ListarEmpleado();
            List<SelectListItem> item = empleado.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre.ToString(),
                    Value = e.iD.ToString(),
                    Selected = false

                };
            });

            ViewBag.empleado = item;

            return View();

        }

        [HttpPost]
        public ActionResult agregarVaciones(Vacione vaca)
        {

            try
            {
                
                Vacaciones_Negocio.agregarVacaciones(vaca);
                //Aqui esto es una prueba para inatibar un empleado
                return Redirect(Url.Content("~/Procesos/ListarVacaciones"));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Ocurrio un error", e.Message);
                return View(vaca);
            }
        }

        //Permisos
        public ActionResult ListarPermiso()
        {
            var lista = Permiso_Negocio.listarpermiso();
            return View(lista);
        }

        public ActionResult agregarPermiso()
        {
            List<Empleado> empleado = Empleado_Negocio.ListarEmpleado();
            List<SelectListItem> item = empleado.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre.ToString(),
                    Selected = false

                };
            });

            ViewBag.empleado = item;
            return View();

        }

        [HttpPost]
        public ActionResult agregarPermiso(Permiso permitir)
        {

            try
            {

                Permiso_Negocio.agregarpermiso(permitir);
                //Aqui esto es una prueba para inatibar un empleado
                return Redirect(Url.Content("~/Procesos/ListarPermiso"));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Ocurrio un error", e.Message);
                return View(permitir);
            }
        }

        //Licencias
        public ActionResult ListarLicencia()
        {
            var lista = Licencia_Negocio.listarlicencia();
            return View(lista);
        }

        public ActionResult agregarLicencia()
        {
            List<Empleado> empleado = Empleado_Negocio.ListarEmpleado();
            List<SelectListItem> item = empleado.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.Nombre.ToString(),
                    Selected = false

                };
            });

            ViewBag.empleado = item;
            return View();

        }

        [HttpPost]
        public ActionResult agregarLicencia(Licencia licen)
        {

            try
            {

                Licencia_Negocio.agregarLicencia(licen);
                //Aqui esto es una prueba para inatibar un empleado
                return Redirect(Url.Content("~/Procesos/ListarLicencia"));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Ocurrio un error", e.Message);
                return View(licen);
            }
        }



    }
}
