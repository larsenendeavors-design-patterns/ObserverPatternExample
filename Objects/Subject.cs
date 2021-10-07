namespace ObserverPatternExample.Objects
{
    public interface Subject
    {
        public void Register(Observer newObserver);
        public void Unregister(Observer oldObserver);
        public void NotifyObservers();
    }
}