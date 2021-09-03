using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomQuotesPage.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace RandomQuotesPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult QuotesInput()
        {
            return View();
        }

        [HttpPost]
        public ViewResult QuotesInput(QuotesModel quotes)
        {
            if (ModelState.IsValid)
            {
                Repository.AddQuote(quotes);
                return View("Thanks", quotes);
            }
            else
            {
                return View();
            }
            
        }

        public ViewResult QuoteList()
        {
            return View(Repository.GetAll);
        }
    }
}
