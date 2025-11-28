using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWidgetBoard.ViewModels;

namespace OpenWidgetBoard.Views;

public partial class ClockWidgetView : Label, IWidgetView
{
    public ClockWidgetView()
    {
        InitializeComponent();
        WidgetViewModel = new ClockWidgetViewModel();
        BindingContext = WidgetViewModel;
    }
    
    public IWidgetViewModel WidgetViewModel { get; set; }
}