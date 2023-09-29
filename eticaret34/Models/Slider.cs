using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret34.Models
{
	public class Slider
	{
        public int SliderId { get; set; }
        public string SliderPicture { get; set; }
        public string SliderText { get; set; }
        [NotMapped]
        public IFormFile ResimEke { get; set; }
    }
}
