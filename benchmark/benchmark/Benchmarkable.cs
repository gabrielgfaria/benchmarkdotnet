namespace benchmark
{
    public class Benchmarkable
    {
        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);
            return dateTime.Year;
        }
    }
}
