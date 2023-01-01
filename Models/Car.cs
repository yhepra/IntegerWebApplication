using System.ComponentModel.DataAnnotations;

namespace IntegerWebApplication.Models
{
    public class Car
    {
        public int IDRegistration { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Varian { get; set; }
    }
}
