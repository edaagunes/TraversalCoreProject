using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class BookingHotelSearchController : Controller
	{
		public async Task<IActionResult> Index()
		{
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?children_ages=5%2C0&page_number=0&adults_number=2&children_number=2&room_number=1&include_adjacency=true&units=metric&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&checkout_date=2025-01-19&dest_id=-1456928&filter_by_currency=EUR&dest_type=city&checkin_date=2025-01-18&order_by=popularity&locale=tr"),
				Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
				return View(values.result);
			}
		}

		[HttpGet]
		public IActionResult GetCityDestId()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> GetCityDestId(string param)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={param}"),
				Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				return View();
			}
		}
	}
}
