using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using TraversalCoreProject.Areas.Admin.Models;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class ApiExchangeController : Controller
	{
		List<BookingExchangeViewModel2> bookingExchangeViewModels = new List<BookingExchangeViewModel2>();
		public async Task<IActionResult> Index()
		{	
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
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
				var values=JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
				return View(values.exchange_rates);
			}
		}
	}
}
