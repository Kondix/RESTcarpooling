using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using Dragon.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dragon.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public ValuesController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "HERZLICH WILKOMMEN";
        }

        [HttpGet("user/all")]
        public string GetUsers()
        {
            return JsonConvert.SerializeObject(Database.Database.GetUsers());
        }

        [HttpGet("user/{id}")]
        public string GetUserById(int userId)
        {
            return JsonConvert.SerializeObject(Database.Database.GetUserById(userId));
        }

        [HttpGet("journey/all")]
        public string GetJourneys()
        {
            return JsonConvert.SerializeObject(Database.Database.GetJourney().Select(WrapJourney));
        }

        [HttpGet("journey/{journeyId}")]
        public string GetJourneyById(int journeyId)
        {
            Journey journey = Database.Database.GetJourneyById(journeyId);
            return JsonConvert.SerializeObject(WrapJourney(journey));
        }

        [HttpGet("route/all")]
        public string GetRoutes()
        {
            return JsonConvert.SerializeObject(Database.Database.GetRoutes());
        }

        [HttpGet("route/{id}")]
        public string GetRouteById(int routeId)
        {
            return JsonConvert.SerializeObject(Database.Database.GetRoutes());
        }

        [HttpPost("addRoute")]
        public void PostRoutes([FromBody]object value)
        {
            Database.Database.AddRoute(JsonConvert.DeserializeObject<Route>(value.ToString()));
        }
        
        [HttpPost("addJourney")]
        public void PostJourney([FromBody]object value)
        {
            Database.Database.AddJourney(JsonConvert.DeserializeObject<Journey>(value.ToString()));
        }

        [HttpPost("addUser")]
        public void PostUsers([FromBody]object value)
        {
            var user = JsonConvert.DeserializeObject<User>(value.ToString());
            user.UserId = Database.Database.GetUserIdCnt();
            Database.Database.AddUser(user);
        }

        private JourneyWrapper WrapJourney(Journey journey)
        {
            JourneyWrapper wrapper = new JourneyWrapper();
            wrapper.IsDriver = journey.IsDriver;
            wrapper.JourneyId = journey.JourneyId;
            wrapper.Route = Database.Database.GetRouteById(journey.RouteId);
            wrapper.Users = journey.UsersIds.Select(Database.Database.GetUserById).ToList();
            return wrapper;
        }
    }
}
