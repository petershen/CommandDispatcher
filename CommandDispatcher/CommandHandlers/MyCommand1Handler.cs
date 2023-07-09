using CommandDispatcher.Commands;
using CommandDispatcher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDispatcher.CommandHandlers
{
    public class MyCommand1Handler : ICommandHandler<MyCommand1>
    {
        public void Execute(MyCommand1 command)
        {
            Console.WriteLine(command.MyCommand1Message);
        }
    }
}
