namespace BlazorApp1.CarModels
{
    public class TaskRanker
    {
        private HistoricalData _historicalData;

        public TaskRanker(HistoricalData historicalData)
        {
            _historicalData = historicalData;
        }

        public double ScoreTask(UserTask task)
        {
            // Start with the task's priority
            double score = task.Priority;

            // Add or subtract other factors from the score. For example:
            // - Subtract the estimated completion time (so quicker tasks get a higher score)
            score -= task.EstimatedCompletionTime;
            // - Subtract the number of days until the deadline (so tasks with sooner deadlines get a higher score)
            score -= (task.Deadline - DateTime.Now).TotalDays;
            // - Add the average completion time for similar tasks in the past
            // score += _historicalData.GetAverageCompletionTime(task);

            return score;
        }

        public List<UserTask> RankTasks(List<UserTask> tasks)
        {
            return tasks.OrderByDescending(t => ScoreTask(t)).ToList();
        }
    }
}
