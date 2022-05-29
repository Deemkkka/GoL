using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GoL.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string Property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            else
            {
                field = value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }

        private bool _Disposed;

        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed)
            {
                return;
            }
            else
            {
                _Disposed = true; //освобождение управляемых ресурсов
            }
        }

    }
}
