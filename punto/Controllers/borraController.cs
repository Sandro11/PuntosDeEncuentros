using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace punto.Controllers
{
    public class borraController : Controller
    {
        //
        // GET: /borra/

        public ActionResult Index()
        {
            punto.Models.puntoencuentroEntities bd = new Models.puntoencuentroEntities();
            punto.Models.tbevento n = new Models.tbevento();
            punto.Models.tbpersona p = new Models.tbpersona();
           // n.idpagos = 1;
           // //n.nombre = "Sandro";
           // n.imagen = "imagen1";
           // n.fechacreacion = DateTime.Now;
           // n.fechamodificacion = DateTime.Now;
           // n.estado=1;
           //// n.tbpagolugares=1;
            //n.estado = 1;
            //n.titulo = "-";
            //p.nombre = "sandro";
            p.paterno = "calcina";
            p.materno = "salvatierra";
            p.ci = "8537253";
            //p.fechanac = "27/12/1991";
            p.fechacreacion = DateTime.Now;
            p.fechamodificacion = DateTime.Now;
            bd.tbpersona.Add(p);
            try
            {
                if (bd.SaveChanges() == 1)
                {
                    // correcto
                }
                else
                {
                    //errores en informacion
                }
            }
            catch { }
            return View();
        }

    }
}
