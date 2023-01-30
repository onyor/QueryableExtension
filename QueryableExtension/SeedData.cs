namespace QueryableExtension
{
    public static class SeedData
    {
        public static User User { get; set; }
        public static City City { get; set; }
        public static District District { get; set; }
        public static Neighborhood Neighborhood { get; set; }

        public static void SeedInit()
        {
            User = new User();
            User.City = new City();
            User.City.District = new District();
            User.City.District.Neighborhood = new Neighborhood();
            User.Name = "Onur";
            User.Surname = "Yildiz";
            User.City.District.Neighborhood.Name = "2344";
            User.City.District.Name = "Etimesgut";
            User.City.Name = "Angara";
        }
    }


    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public City City { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public District District { get; set; }
    }

    public class District
    {
        public string Name { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }

    public class Neighborhood
    {
        public string Name { get; set; }
    }
}
