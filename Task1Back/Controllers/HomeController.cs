using Microsoft.AspNetCore.Mvc;
using Task1Back.Models;


namespace Task1Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _markas;

        public HomeController()
        {
            _markas = new List<Marka>
            {
                new Marka{Id = 1,Name="Tesla",Country="Texas",YearFounded=2003},
                new Marka{Id = 2,Name="BMW",Country="German",YearFounded=1916},
                new Marka{Id = 3,Name="AUDI",Country="German",YearFounded=1986},
                new Marka{Id = 4,Name="Acura",Country="Tokyo",YearFounded=2006},
                new Marka{Id = 5,Name="FERRARI",Country="Itali",YearFounded=1884},
                new Marka{Id = 6,Name="MERCEDES",Country="German",YearFounded=1894}

            };
        }

        public IActionResult Index()
        {
            return View(_markas);
        }
        public IActionResult Detail(int? id)
        {

            if (id == null) return BadRequest("Id bos qoyula bilmez");

          if (!_markas.Exists(m => m.Id == id))
            {
                return NotFound("Gonderilen id yanlisdir");
            }

            Marka marka=_markas.Find(m => m.Id == id);


            return View(marka);
        }
    }
}



















