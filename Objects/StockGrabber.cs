using System.Collections.Generic;

namespace ObserverPatternExample.Objects
{
    public class StockGrabber : Subject
    {
        private List<Observer> observers { get; set; } = new List<Observer>();

        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unregister(Observer oldObserver)
        {
            observers.Remove(oldObserver);
        }

        public void NotifyObservers()
        {
            observers.ForEach(o => o.Update(IbmPrice, AaplPrice, GoogPrice));
        }

        private double _googPrice;

        public double GoogPrice
        {
            get => _googPrice;
            set
            {
                _googPrice = value;
                NotifyObservers();
            }
        }

        private double _aaplPrice;

        public double AaplPrice
        {
            get => _aaplPrice;
            set
            {
                _aaplPrice = value;
                NotifyObservers();
            }
        }

        private double _ibmPrice;

        public double IbmPrice
        {
            get => _ibmPrice;
            set
            {
                _ibmPrice = value;
                NotifyObservers();
            }
        }
    }
}