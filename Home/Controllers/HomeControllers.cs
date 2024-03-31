using System.Data;
using Microsoft.AspNetCore.Mvc;
using myapp.Home.Models;
using myapp.Home.Providers;
using myapp.Home.ResponseModels;

namespace myapp.Home.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController: ControllerBase
    {
        readonly IHomeProvider _homeProvider;

        public HomeController (IHomeProvider homeProvider)
        {
            _homeProvider = homeProvider;
        }
    

    [Route("person")]
    [HttpGet]
    public PersonsResponseModel Get()
    {
       return _homeProvider.GetPersons();
    }

    } 
}