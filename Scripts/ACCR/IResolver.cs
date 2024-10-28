using System.Collections.Generic;
using Resolvers.Actions;

namespace ACCR
{
    public interface IResolver : IObservable
    {
        public void AddAction(IAction action);
        public void RemoveAction(IAction action);
        public List<IAction> GetListOfActions();
        public void Resolve();
    }
}
