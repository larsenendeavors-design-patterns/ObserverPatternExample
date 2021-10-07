using System;
using System.Text;

namespace ObserverPatternExample.Objects
{
    public class StockObserver : Observer
    {
        private double IbmPrice { get; set; }
        private double AaplPrice { get; set; }
        private double GoogPrice { get; set; }

        private static int _observerIdTracker = 0;
        private int ObserverId { get; set; }

        private Subject StockGrabber { get; set; }

        public StockObserver(Subject stockGrabber)
        {
            StockGrabber = stockGrabber;
            ObserverId = ++_observerIdTracker;
            Console.WriteLine("Observer created: Id: " + ObserverId);
            // This is where the magic happens, the observer is created
            // and immediately registered to the subject.
            StockGrabber.Register(this);
        }


        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            IbmPrice = ibmPrice;
            AaplPrice = aaplPrice;
            GoogPrice = googPrice;
            
            PrintThePrices();
        }

        private void PrintThePrices()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ObserverId: " + ObserverId);
            stringBuilder.AppendLine("IBM: " + IbmPrice);
            stringBuilder.AppendLine("AAPL: " + AaplPrice);
            stringBuilder.AppendLine("GOOG: " + GoogPrice);

            Console.Write(stringBuilder.ToString());
        }
    }
}