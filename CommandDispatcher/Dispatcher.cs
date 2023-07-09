using CommandDispatcher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Input;

namespace CommandDispatcher
{
    public class Dispatcher
    {
        public void Dispatch<TCommand>(TCommand command) where TCommand : CommandDispatcher.Interfaces.ICommand
        {
            Type[] concreteHandlerTypes = GetHandlerTypes(command);
            foreach(Type type in concreteHandlerTypes)
            {
                var concreteHandler = Activator.CreateInstance(type) as ICommandHandler<TCommand>;
                concreteHandler.Execute(command);
            }
        }

        private Type[] GetHandlerTypes<TCommand>(TCommand command) where TCommand : CommandDispatcher.Interfaces.ICommand
        {
            Type handlerType = typeof(ICommandHandler<>);
            Type ConstructedHandlerType = handlerType.MakeGenericType(command.GetType());
            Type[] concreteHandlerTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.GetInterfaces().Contains(ConstructedHandlerType)).ToArray();
            return concreteHandlerTypes;
        }
    }
}
