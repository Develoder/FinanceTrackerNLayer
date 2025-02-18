namespace MyExtension
{
    public static class DataExtension
    {
        public static DateTime FirstDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime LastDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1, 23, 59, 59).AddMonths(1).AddDays(-1);
        }
    }
}
