using System.Web.Mvc;
using Negocio.Logica;

namespace Presentacion1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            /*UsuarioLogica.ValidarLogin("mail@mail.com", "Test1234");*/
            UsuarioLogica.getPermisos(2);
            return View();
        }
    }
}