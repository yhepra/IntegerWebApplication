using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class CarController : Controller
    {
        
        public IActionResult Index()
        {
            //var cars = new List<Car>();
            //IEnumerable<Car> cars = new List<Car>();

            //cars.Add(new Car()
            //{
            //    IDRegistration = 1,
            //    Type = "Sedan",
            //    Brand = "Toyota",
            //    Varian = "Black"
            //});

            //cars.Add(new Car()
            //{
            //    IDRegistration = 2,
            //    Type = "Sedan",
            //    Brand = "BMW",
            //    Varian = "White"
            //});

            //cars.Add(new Car()
            //{
            //    IDRegistration = 3,
            //    Type = "SUV",
            //    Brand = "Hyundai",
            //    Varian = "Matte"
            //});

            var cars = new Car[] //array
            {
                new Car{ IDRegistration = 1, Type = "Sedan", Brand = "Toyota", Varian = "FT86"},
                new Car{ IDRegistration = 2, Type = "SUV", Brand = "Toyota", Varian = "RAV4"},
                new Car{ IDRegistration = 3, Type = "Sedan", Brand = "Honda", Varian = "Accord"},
                new Car{ IDRegistration = 4, Type = "SUV", Brand = "Honda", Varian = "CRV"},
                new Car{ IDRegistration = 5, Type = "Sedan", Brand = "Honda", Varian = "City"}
            };




            //var cari = cars.Single(x => x.IDRegistration == 2);
            //cars.Remove(cari);

            //ViewBag.Cars = cars;

            var car = cars.Where(x => x.Type == "Sedan").LastOrDefault();
            ViewBag.Cars = new List<Car>() { car };

            return View();
        }
    }
}
