using myapp.Home.Models;
using myapp.Home.ResponseModels;
using System.Data;
using Microsoft.AspNetCore;
using myapp.Home.Services;

namespace myapp.Home.Providers
{
    public interface IHomeProvider
    {
        public PersonsResponseModel GetPersons();
    }

        public class HomeProvider : IHomeProvider
        {
            public IHomeService _homeService;

            public HomeProvider(IHomeService homeService)
            {
                _homeService = homeService;
            }
            public PersonsResponseModel GetPersons()
            {
                var persons = _homeService.GetPersons();
                PersonsResponseModel PersonList = new()
                {
                    PersonsList= persons
                };
                return PersonList;
            }

        }
}