using Microsoft.AspNetCore.Mvc;
using Task1Back.Models;

namespace Task1Back.Controllers
{
    public class CarsController : Controller
    {
        private readonly List<Car> _cars;

        public CarsController()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,Count=23,Description="Ela"},
                new Car{Id = 2,Count=2,Description="pis"},
                new Car{Id = 3,Count=34,Description="surulub"},
                new Car{Id = 4,Count=65,Description="vurulub"},
                new Car{Id = 5,Count=73,Description="suda qalb"},
                new Car{Id = 5,Count=72,Description="teze"},
            };
        }


        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_cars);
            }
            else
            {
                if (_cars.Exists(x => x.MOdelId == id))
                {
                    List<Car> cars = _cars.FindAll(x => x.MOdelId == id);
                    return View(cars);
                }
                else
                {
                    return NotFound("ID yanlisdir");
                }
            }

        }
    }
}
