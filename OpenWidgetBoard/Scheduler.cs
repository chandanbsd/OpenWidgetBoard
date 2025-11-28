namespace OpenWidgetBoard;

public class Scheduler
{
    public void ScheduleAction(TimeSpan delay, Action action)
    {
        Task.Run(async () =>
        {
            await Task.Delay(delay);
            action.Invoke();
        });
    }
}