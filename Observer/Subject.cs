using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {

        void NotifyObservers();
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }


    public class Nut : ISubject
    {
        private IList<IObserver> _observers = new List<IObserver>();
        public double Price { get; set; }


        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
