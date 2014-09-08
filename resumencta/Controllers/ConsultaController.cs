using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Net;

namespace resumencta.Controllers
{
    public class ConsultaController : Controller
    {
        //
        // GET: /Consulta/

        public ActionResult Index()
        {
            try
            {
                return File(".\\pdf.pdf", "application/pdf", "pdf.pdf");
            }
            catch(Exception ex) {
                Response.StatusCode = 500;
                return Content(ex.Message);
            }
        }

    }
}
