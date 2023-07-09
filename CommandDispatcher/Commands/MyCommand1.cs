using CommandDispatcher.Interfaces;

namespace CommandDispatcher.Commands
{
    public class MyCommand1 : ICommand
    {
        private readonly string _message;

        public MyCommand1(string message)
        {
            _message = message;   
        }

        public string MyCommand1Message {
            get
            {
                return _message;
            } 
        }
    }
}
