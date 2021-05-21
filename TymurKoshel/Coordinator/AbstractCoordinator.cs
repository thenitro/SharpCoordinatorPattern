using System;
using System.Collections.Generic;
using System.Linq;

namespace TymurKoshel.Coordinator
{
    public class AbstractCoordinator : ICoordinator
    {
        public virtual IDelegate Delegate { get; }

        private HashSet<ICoordinator> _children = new HashSet<ICoordinator>();
        
        public void Present(IDelegate coordinatorDelegate = null)
        {
            OnPresent(coordinatorDelegate);
        }

        public void Dismiss()
        {
            foreach (var coordinator in _children.ToList())
            {
                coordinator.Dismiss();
            }
            
            _children.Clear();
            
            OnDismiss();
        }

        public void AddChild(ICoordinator coordinator)
        {
            if (_children.Contains(coordinator))
            {
                return;
            }

            _children.Add(coordinator);
        }

        public void RemoveChild(ICoordinator coordinator)
        {
            if (!_children.Contains(coordinator))
            {
                return;
            }

            _children.Remove(coordinator);
        }

        protected virtual void OnPresent(IDelegate coordinatorDelegate = null)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDismiss()
        {
            throw new NotImplementedException();
        }
    }
}