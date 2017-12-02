using System.Collections.Generic;
using System.Linq;
using Dragon.DTO;

namespace Dragon.Database
{
    public class Database
    {
        private readonly List<Journey> _journeys;
        private readonly List<Route> _routes;
        private readonly List<User> _users;

        public Database()
        {
            _journeys = new List<Journey>();
            _routes = new List<Route>();
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public User GetUserById(int userId)
        {
            return _users.First(user => user.UserId == userId);
        }

        public void AddRoute(Route route)
        {
            _routes.Add(route);
        }

        public List<Route> GetRoutes()
        {
            return _routes;
        }

        public Route GetRouteById(int routeId)
        {
            return _routes.First(route => route.RouteId == routeId);
        }

        public void AddJourney(Journey journey)
        {
            _journeys.Add(journey);
        }

        public List<Journey> GetJourney()
        {
            return _journeys;
        }

        public Journey GetJourneyById(int journeyId)
        {
            return _journeys.First(journey => journey.JourneyId == journeyId);
        }
    }
}

