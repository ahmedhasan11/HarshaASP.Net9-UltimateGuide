﻿using Microsoft.AspNetCore.Mvc;

namespace LayoutViews.Controllers
{
    public class ProductController : Controller
    {
		[Route("products")]
		public IActionResult Index()
		{
			return View();
		}

		[Route("search-products")]
		public IActionResult Search()
		{
			return View();
		}

		[Route("order-product")]
		public IActionResult Order()
		{
			return View();
		}
	}
}
