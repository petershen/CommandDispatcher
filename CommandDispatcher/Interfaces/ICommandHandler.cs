namespace CommandDispatcher.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : CommandDispatcher.Interfaces.ICommand
    {
        void Execute(TCommand command);
    }
}
