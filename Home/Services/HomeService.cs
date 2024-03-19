using Microsoft.AspNetCore;
using myapp.DataContext.DataModels.General;
using myapp.DataContext;

namespace myapp.Home.Services
{
    public interface IHomeService
    {
        public List<Persons> GetPersons();
    }

    public class HomeService : IHomeService
    {
        public DatabaseContext _dbContext;

    

    public HomeService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Persons> GetPersons()
    {
        return _dbContext.Persons.ToList();
    }
    }
}