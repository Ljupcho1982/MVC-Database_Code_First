using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PeopleController : Controller
    {

        public PersonContext dbCon;

        public PeopleController(PersonContext dbCon)
        {
            this.dbCon = dbCon;
        }

        public IActionResult Index()
        {
            IEnumerable<Person> ListofPeople = dbCon.People;

            return View(ListofPeople);
        }
    }
}
