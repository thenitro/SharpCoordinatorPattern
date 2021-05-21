namespace TymurKoshel.Coordinator
{
    public interface IRouter
    {
        void Transition(ICoordinator parent, ICoordinator current, ICoordinator next);
    }
}