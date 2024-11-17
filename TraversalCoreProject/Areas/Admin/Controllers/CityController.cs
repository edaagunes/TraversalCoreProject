using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class CityController : Controller
	{
		private readonly IDestinationService _destinationService;

		public CityController(IDestinationService destinationService)
		{
			_destinationService = destinationService;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CityList()
		{
			var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
			return Json(jsonCity);
		}

		[HttpPost]
		public IActionResult AddCityDestination([FromBody] Destination destination)
		{
			if (destination == null)
			{
				return BadRequest("Eksik veya hatalı veri gönderildi."); // Hatalı istek kontrolü
			}

			destination.Status = true; // Varsayılan durumu aktif olarak ayarla
			_destinationService.TAdd(destination); // Veritabanına ekle

			var values = JsonConvert.SerializeObject(destination); // Eklendikten sonra veriyi döndür
			return Json(values);
		}
		[HttpGet]
		public IActionResult GetById(int id)
		{
			var values = _destinationService.TGetById(id);
			//	var jsonValues = JsonConvert.SerializeObject(values);
			return Json(values);
		}

		public IActionResult DeleteCity(int id)
		{
			var values = _destinationService.TGetById(id);
			_destinationService.TDelete(values);
			return NoContent();
		}

		[HttpPost]
		public IActionResult UpdateCity([FromBody] Destination destination)
		{
			// Boş alan kontrolü
			if (string.IsNullOrEmpty(destination.City) || string.IsNullOrEmpty(destination.DayNight) || destination.DestinationId <= 0)
			{
				return Json(new { success = false, message = "Lütfen tüm alanları doldurun." });
			}

			// Güncelleme işlemi
			_destinationService.TUpdate(destination); // Veritabanı güncelleme işlemi
			Console.WriteLine("Güncelleme başarılı!");
			return Json(new { success = true, message = "Şehir başarıyla güncellendi." });

		}


		//public static List<CityClass> cities = new List<CityClass>
		//{
		//    new CityClass
		//    {
		//        CityID=1,
		//        CityName="Üsküp",
		//        CityCountry="Makedonya"
		//    },
		//    new CityClass
		//    {
		//        CityID=2,
		//        CityName="Roma",
		//        CityCountry="İtalya"
		//    },
		//    new CityClass
		//    {
		//        CityID=3,
		//        CityName="Londra",
		//        CityCountry="İngiltere"
		//    }
		//};

	}
}
