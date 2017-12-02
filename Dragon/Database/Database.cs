using System.Collections.Generic;
using System.Linq;
using Dragon.DTO;

namespace Dragon.Database
{
    public static class Database
    {
        private static readonly List<Journey> Journeys;
        private static readonly List<Route> Routes;
        private static readonly List<User> Users;
        private static int _userIdCnt;
        private static int _routeIdCnt;
        private static int _journeyIdCnt;

        static Database()
        {
            Journeys = new List<Journey>();
            Routes = new List<Route>();
            Users = new List<User>();
            _userIdCnt = 0;
        }

        public static int GetUserIdCnt()
        {
            _userIdCnt++;
            return _userIdCnt;
        }

        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        public static List<User> GetUsers()
        {
            return Users;
        }

        public static User GetUserById(int userId)
        {
            return Users.First(user => user.UserId == userId);
        }

        public static void AddRoute(Route route)
        {
            Routes.Add(route);
        }

        public static List<Route> GetRoutes()
        {
            return Routes;
        }

        public static Route GetRouteById(int routeId)
        {
            return Routes.First(route => route.RouteId == routeId);
        }

        public static void AddJourney(Journey journey)
        {
            Journeys.Add(journey);
        }

        public static List<Journey> GetJourney()
        {
            return Journeys;
        }

        public static Journey GetJourneyById(int journeyId)
        {
            return Journeys.First(journey => journey.JourneyId == journeyId);
        }
    }
}

