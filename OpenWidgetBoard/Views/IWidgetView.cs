using OpenWidgetBoard.ViewModels;

namespace OpenWidgetBoard.Views;

public interface IWidgetView
{
    int Position
    {
        get => WidgetViewModel.Position; 
        set => WidgetViewModel.Position = value;
    }
    
    IWidgetViewModel WidgetViewModel { get; set; }
}