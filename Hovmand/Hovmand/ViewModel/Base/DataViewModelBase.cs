using System.ComponentModel;
using System.Runtime.CompilerServices;
using Hovmand.Annotations;

namespace Hovmand.ViewModel.Base
{
    public class DataViewModelBase<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private T _domainObject;

        public T DomainObject
        {
            get { return _domainObject; }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}