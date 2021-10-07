namespace ObserverPatternExample.Objects
{
    public interface Observer
    {
        public void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}