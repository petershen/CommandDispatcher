using CommandDispatcher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDispatcher.Commands
{
    internal class MyCommand2 : ICommand
    {
        private readonly string _message;

        public MyCommand2(string message)
        {
            _message = message;
        }

        public string MyCommand2Message
        {
            get
            {
                return _message;
            }
        }
    }
}
