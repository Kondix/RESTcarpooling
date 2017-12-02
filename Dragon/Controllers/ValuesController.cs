using System.Net.Http;
using Dragon.DTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dragon.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly Database.Database _database;

        public ValuesController()
        {
            _database = new Database.Database();
        }

        [HttpGet]
        public string Get()
        {
            return "HERZLICH WILKOMMEN";
        }

        [HttpGet("user/all")]
        public string GetUsers()
        {
            _database.AddUser(new User() {Name = "Konrad", UserId = 1});
            return JsonConvert.SerializeObject(_database.GetUsers());
        }

        [HttpGet("user/{id}")]
        public string GetUserById(int userId)
        {
            return JsonConvert.SerializeObject(_database.GetUserById(userId));
        }

        [HttpGet("journey/all")]
        public string GetJourneys()
        {
            return JsonConvert.SerializeObject(_database.GetJourney());
        }

        [HttpGet("journey/{id}")]
        public string GetJourneyById(int journeyId)
        {
            return JsonConvert.SerializeObject(_database.GetJourneyById(journeyId));
        }

        [HttpGet("route/all")]
        public string GetRoutes()
        {
            return JsonConvert.SerializeObject(_database.GetRoutes());
        }

        [HttpGet("route/{id}")]
        public string GetRouteById(int routeId)
        {
            return JsonConvert.SerializeObject(_database.GetRoutes());
        }

        [HttpPost("addRoute")]
        public void PostRoutes([FromBody]string value)
        {
            _database.AddRoute(JsonConvert.DeserializeObject<Route>(value));
        }
        
        [HttpPost("addJourney")]
        public void PostJourney([FromBody]string value)
        {
            _database.AddJourney(JsonConvert.DeserializeObject<Journey>(value));
        }

        [HttpPost("addUser")]
        public void PostUsers([FromBody] string value)
        {
            _database.AddUser(JsonConvert.DeserializeObject<User>(value));
        }
    }
}
