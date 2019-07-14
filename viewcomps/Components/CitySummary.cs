using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using viewcomps.Models;

namespace viewcomps.Components
{
    public class CitySummary : ViewComponent
    {
        ICityRepository repository;
        public CitySummary(ICityRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(new CityViewModel {
                Cities = repository.Cities.Count(),
                Population = repository.Cities.Sum(c=>c.Population),
            });
        }
    }

}
