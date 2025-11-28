using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OpenWidgetBoard.ViewModels;

public class BaseViewModel: INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    
    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetProperty<TValue>(ref TValue backingField, TValue value,
        [CallerMemberName] string propertyName = "")
    {
        if (Comparer<TValue>.Default.Compare(backingField, value) == 0)
        {
            return false;
        }

        backingField = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}