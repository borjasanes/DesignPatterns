using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Behavioral.Observer
{
    /// <summary>
    /// Define a one-to-many dependency between objects so that when one object changes state
    /// all its dependents are notified and updated automatically.
    /// </summary>
    public class Contact : IObservable<Contact>
    {
        private readonly List<IObserver<Contact>> _observers = new List<IObserver<Contact>>();

        public IDisposable Subscribe(IObserver<Contact> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new UnsubscribeContact(_observers, observer);
        }

        private string _name { get; set; }

        public string Name
        {
            get => _name;
            set

            {
                if (_name == value) return;
                _name = value;
                Notify();
            }
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(this);
            }
        }
    }

    public abstract class Observer<T>
    {
        public abstract void Update(T subject);
    }

    public class CrmObserver : IObserver<Contact>
    {
        public string Name { get; set; }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Contact value)
        {
            Name = value.Name;
        }
    }

    public class UnsubscribeContact : IDisposable
    {
        private readonly IList<IObserver<Contact>> _observers;
        private readonly IObserver<Contact> _observer;

        public UnsubscribeContact(IList<IObserver<Contact>> observers, IObserver<Contact> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null) _observers.Remove(_observer);
        }
    }
}
