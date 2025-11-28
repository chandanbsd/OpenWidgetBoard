using System.ComponentModel;

namespace OpenWidgetBoard.ViewModels;

public class ClockWidgetViewModel : BaseViewModel, IWidgetViewModel
{
    private readonly Scheduler scheduler = new();

    private DateTime time;

    public DateTime Time
    {
        get => time;
        
        set => SetProperty(ref time, value);
    }

    public int Position { get; set; }

    public string Type
    {
        get => "Clock";
        set => throw new NotImplementedException();
    }

    public ClockWidgetViewModel()
    {
        SetTime(DateTime.Now);
    }

    private void SetTime(DateTime dateTime)
    {
        Time = dateTime;
        scheduler.ScheduleAction(
            TimeSpan.FromSeconds(1),
            () => SetTime(DateTime.Now));
    }
}