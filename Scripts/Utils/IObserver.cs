
namespace Utils
{
    public interface IObserver
    {
        public void Attach(IObservable listener);
        public void Detach(IObservable listener);
        public void Notify();
    }
}
