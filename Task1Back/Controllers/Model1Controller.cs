using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Task1Back.Models;

namespace Task1Back.Controllers
{
    public class Model1Controller : Controller
    {
        private readonly List<Model1> _model;

        public Model1Controller()
        {
            _model = new List<Model1>
            {
                new Model1{MarkaID=1, Id = 1,Name="Model S",Year=2009,Horsepower=768},
                new Model1{MarkaID=2,Id = 2,Name="M5",Year=1992,Horsepower=568},
                new Model1{MarkaID=3,Id = 3,Name="A8",Year=2001,Horsepower=468},
                new Model1{MarkaID=4,Id = 4,Name="D6",Year=2004,Horsepower=668},
                new Model1{MarkaID=5,Id = 5,Name="S",Year=1897,Horsepower=788},
                new Model1{MarkaID=6,Id = 6,Name="G-300",Year=1984,Horsepower=368},
             
            };
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_model);
            }
            else
            {
                if(_model.Exists(x =>x.MarkaID==id)) 
                { 
                    List<Model1> models = _model.FindAll(x => x.MarkaID == id);
                    return View(models);
                }
                else
                {
                    return NotFound("ID yanlisdir");
                }
            }
                 
        }
    }
}
