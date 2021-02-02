using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_candyRepository.GetAllCandy);

            var candyListViewMode = new CandyListViewModel();
            candyListViewMode.Candies = _candyRepository.GetAllCandy;
            candyListViewMode.CurrentCategory = "BestSellers";
            return View(candyListViewMode);
        }

        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if (candy == null)
                return NotFound();

            return View(candy);
        }
    }
}
