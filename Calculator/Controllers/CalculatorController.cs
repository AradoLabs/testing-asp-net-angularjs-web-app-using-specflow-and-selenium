using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View();
        }
	}
}