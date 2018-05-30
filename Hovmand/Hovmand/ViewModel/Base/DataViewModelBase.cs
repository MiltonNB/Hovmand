using Hovmand.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hovmand.ViewModel.Base
{
    public class DataViewModelBase<T> : INotifyPropertyChanged where T : class
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