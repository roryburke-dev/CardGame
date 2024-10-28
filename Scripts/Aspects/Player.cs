

using ACCR;

namespace Aspects
{
    public class Player : IAspect
    {
        private IContainer _container;
        
        public void SetContainer(IContainer container)
        {
            _container = container;
        }

        public IContainer GetContainer()
        {
            return _container;
        }
    }
}
