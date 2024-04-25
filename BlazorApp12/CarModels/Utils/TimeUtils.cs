namespace BlazorApp1.CarModels.Utils
{
    public class TimeUtils
    {
        public TimeSpan CalculateTimeDifference(DateTimeOffset firstTime, DateTimeOffset secondTime)
        {
            return secondTime - firstTime;
        }

        public DateTimeOffset ConvertToTimeZone(DateTimeOffset dateTime, TimeZoneInfo timeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTime, timeZone);
        }

        public TimeSpan AverageTimeSpan(List<TimeSpan> timeSpans)
        {
            long totalTicks = 0;
            foreach (var timeSpan in timeSpans)
            {
                totalTicks += timeSpan.Ticks;
            }
            long averageTicks = totalTicks / timeSpans.Count;
            return new TimeSpan(averageTicks);
        }

        public TimeSpan TotalTimeSpan(List<TimeSpan> timeSpans)
        {
            TimeSpan totalTime = TimeSpan.Zero;
            foreach (var timeSpan in timeSpans)
            {
                totalTime += timeSpan;
            }
            return totalTime;
        }

        public DateTimeOffset GetLocalDateTimeOffset()
        {
            return DateTimeOffset.Now;
        }

        public DateTimeOffset GetUtcDateTimeOffset()
        {
            return DateTimeOffset.UtcNow;
        }

        public List<TimeZoneInfo> GetAllTimeZones()
        {
            return TimeZoneInfo.GetSystemTimeZones().ToList();
        }
    }

}
