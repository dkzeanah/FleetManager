namespace BlazorApp1.CarModels
{
    public class EventRanker
    {
        private HistoricalData _historicalData;
        private double score;

        public EventRanker(HistoricalData historicalData)
        {
            _historicalData = historicalData;
        }

        // Assigns a score to an event. The higher the score, the higher the priority.
        public double ScoreEvent(UserCarEvent e)
        {
            // Start with the event's default priority
            //double score = e.Category.DefaultPriority;

            // You can then add other factors to the score. For example:
            // - Add the event's frequency
            // score += _historicalData.GetFrequency(e);
            // - Subtract the time since the last occurrence (so more recent events have a higher score)
            // score -= _historicalData.GetTimeSinceLastOccurrence(e);

            return score;
        }

        // Ranks a list of events based on their scores.
        public List<UserCarEvent> RankEvents(List<UserCarEvent> events)
        {
            // Sort the events based on their scores.
            return events.OrderByDescending(e => ScoreEvent(e)).ToList();
        }
    }

}
