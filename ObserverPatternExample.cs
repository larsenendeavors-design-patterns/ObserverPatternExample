using ObserverPatternExample.Objects;

namespace ObserverPatternExample
{
 /*
 * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
 * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
 * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
 * I'm happy that you're here and here's proof that I have at least heard of this particular
 * pattern!
 *
 * Author: Nicholas Larsen
 * Date: 2021/10/07
 */
 
    class ObserverPatternExample
    {
        static void Main(string[] args)
        {
            // This is how we use the observer Pattern, we have a primary
            // object that gets observers registered to it
            // When a change occurs, the subject notifies the observers
            // in this case, when a price is updated, the observers print
            // their prices out.
            var stockGrabber = new StockGrabber();
            var stockObserver1 = new StockObserver(stockGrabber);
            var stockObserver2 = new StockObserver(stockGrabber);
            var stockObserver3 = new StockObserver(stockGrabber);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.AaplPrice = 677.60;
            stockGrabber.GoogPrice = 676.40;
        }
    }
}