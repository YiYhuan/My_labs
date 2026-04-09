using backend_lab.Handlers.backend_lab.Repositories;
using backend_lab_C34259.Models;
namespace backend_lab.Services
{
    public class CountryService
    {
        private readonly CountryRepository countryRepository;
        public CountryService()
        {
            countryRepository = new CountryRepository();
        }
        public List<CountryModel> GetCountries()
        {
            // Add any missing business logic when it is neccesary
        return countryRepository.GetCountries();
        }
    }
}