namespace TymurKoshel.Coordinator
{
    public interface ICoordinator
    {
        IDelegate Delegate { get; }
        void Present(IDelegate coordinatorDelegate = null);
        void Dismiss();
        void AddChild(ICoordinator coordinator);
        void RemoveChild(ICoordinator coordinator);
    }
}