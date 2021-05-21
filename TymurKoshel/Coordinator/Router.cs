namespace TymurKoshel.Coordinator
{
    public class Router : IRouter
    {
        public void Transition(ICoordinator parent, ICoordinator current, ICoordinator next)
        {
            current?.Dismiss();
            parent.RemoveChild(current);
            next.Present(parent.Delegate);
            parent.AddChild(next);
        }
    }
}