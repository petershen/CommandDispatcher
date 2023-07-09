// See https://aka.ms/new-console-template for more information

using CommandDispatcher;
using CommandDispatcher.Commands;

Dispatcher dispatcher = new Dispatcher();
dispatcher.Dispatch(new MyCommand1("Handle MyCommand1"));
dispatcher.Dispatch(new MyCommand2("Handle MyCommand2"));
