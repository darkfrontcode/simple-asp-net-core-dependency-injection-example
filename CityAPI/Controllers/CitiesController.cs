using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
	[Route("api/cities")]
    public class CitiesController : Controller
    {
		[HttpGet()]
		public IActionResult GetCities()
		{
			return Ok(Store.CitiesStore.Current.Cities);
		}

		[HttpGet("{id}")]
		public IActionResult GetCity(int id)
		{
			var search = Store.CitiesStore.Current.Cities.FirstOrDefault(city => city.Id == id);
			if(search == null)
			{
				return NotFound();
			}

			return Ok(search);
		}
	}
}
