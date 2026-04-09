using backend_lab.Services;
using backend_lab.Handlers.backend_lab.Repositories;
using backend_lab_C34259.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_lab_C34259.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryService countryService;

        public CountryController()
        {
            countryService = new CountryService();
        }

        [HttpGet]
        public List<CountryModel> Get()
        {
            var paises = countryService.GetCountries();
            return paises;
        }
    }
}
