namespace QueryableExtension.Extensions
{
    public static class Aggregate
    {
        public static void Test(User onyore)
        {
            var test = onyore.xGetMemberValue("City.District.Neighborhood.Name");
            Console.WriteLine("test: " + test);
        }
    }

}
