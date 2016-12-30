using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GoogleMaps.Bindings.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(property, value))
            {
                property = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
