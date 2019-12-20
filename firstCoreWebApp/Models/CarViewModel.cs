using System.ComponentModel.DataAnnotations;

namespace firstCoreWebApp.Models
{
    public class CarViewModel
    {    

        [Required]
        public string Brand { get; set; }


        [Required]
        public string ModelName { get; set; }
    }
}