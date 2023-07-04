using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class ExpenditureController : Controller
    {
        public List<Expenditure> ExpenditureLog = new List<Expenditure>();

        public ExpenditureController()
        {
            this.ExpenditureLog.Add(new Expenditure("lait", DateTime.Parse("22/12/2022"), 5.20));
            this.ExpenditureLog.Add(new Expenditure("cookies", DateTime.Parse("23/12/2022"), 4.70));
            this.ExpenditureLog.Add(new Expenditure("allume-feu", DateTime.Parse("24/12/2022"), 15));
        }

        // GET: ExpenditureController
        public ActionResult Index()
        {
            return View(ExpenditureLog);
        }
    }
}
