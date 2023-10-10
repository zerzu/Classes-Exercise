namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var automobile1 = new Car();
            automobile1.Make = "Lincoln";
            automobile1.Model = "Navigator";
            automobile1.Year = 2005;

            Console.WriteLine($"This is a {automobile1.Make} {automobile1.Model}, made in the year {automobile1.Year}.");
        }
    }
}
