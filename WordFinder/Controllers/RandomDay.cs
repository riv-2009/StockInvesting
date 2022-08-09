namespace WordFinder.Controllers
{
    public class RandomDay
    {
        public Random r = new Random();
        public DateTime GetRandomDay()
        {
            DateTime start = new DateTime(2020, 8, 1);
            DateTime sixMonthAgo = new DateTime(2022, 2, 5);
            int range = (sixMonthAgo - start).Days;
            return start.AddDays(r.Next(range));
        }
    }
}
