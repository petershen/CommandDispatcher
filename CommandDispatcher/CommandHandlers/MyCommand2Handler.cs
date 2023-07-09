using CommandDispatcher.Commands;
using CommandDispatcher.Interfaces;

namespace CommandDispatcher.CommandHandlers
{
    internal class MyCommand2Handler : ICommandHandler<MyCommand2>
    {
        void ICommandHandler<MyCommand2>.Execute(MyCommand2 command)
        {
            Console.WriteLine(command.MyCommand2Message);
        }
    }
}
