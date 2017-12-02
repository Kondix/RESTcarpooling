using System.Collections.Generic;
using System.Data.SqlTypes;
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
            Generate();
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

        private static void Generate()
        {
            ///////////////////USERS
            Users.Add(new User
            {
                Name = "Janek",
                UserId = 1
            });
            Users.Add(new User
            {
                Name = "Józek",
                UserId = 2
            });
            Users.Add(new User
            {
                Name = "Ksawery",
                UserId = 3
            });
            Users.Add(new User
            {
                Name = "Bartek",
                UserId = 4
            });
            Users.Add(new User
            {
                Name = "Franek",
                UserId = 5
            });
            ///////////////////ROUTES
            Routes.Add(new Route
            {
                RouteId = 1,
                Capacity = 2,
                StartPosition = new Position { PositionX = "50.0732856", PositionY = "19.9937139" },
                EndPosition = new Position { PositionX = "50.0641583", PositionY = "19.9458837" }
            });
            Routes.Add(new Route
            {
                RouteId = 2,
                Capacity = 4,
                StartPosition = new Position { PositionX = "50.0759008", PositionY = "19.9315232" },
                EndPosition = new Position { PositionX = "50.087573", PositionY = "19.9791868" }
            });
            Routes.Add(new Route
            {
                RouteId = 3,
                Capacity = 3,
                StartPosition = new Position { PositionX = "50.0555608", PositionY = "19.9464989" },
                EndPosition = new Position { PositionX = "50.0556582", PositionY = "19.9343909" }
            });
            ///////////////////JOURNEYS
            Journeys.Add(new Journey
            {
                IsDriver = true,
                JourneyId = 1,
                RouteId = 1,
                UsersIds = new List<int>() {2, 4}
            });
            Journeys.Add(new Journey
            {
                IsDriver = true,
                JourneyId = 2,
                RouteId = 3,
                UsersIds = new List<int>() { 1, 5, 3 }
            });
            Journeys.Add(new Journey
            {
                IsDriver = true,
                JourneyId = 3,
                RouteId = 2,
                UsersIds = new List<int>() { 1, 2, 4 }
            });
        }
    }
}

