using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parametrize
    /// clients with different requests and support undoable operations.
    /// Need to issue requests to objects without knowing anything about the operation
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface ICommandHandler<in TCommand>
    {
        void Handle(TCommand command);
        void Undo();
    }

    public class NewUserCommandHandler : ICommandHandler<NewUser> //originator
    {
        private readonly List<NewUserMemento> _mementos = //Caretaker 
            new List<NewUserMemento>();

        public void Handle(NewUser command)
        {
            //preform action with the command
            _mementos.Add(new NewUserMemento(command));

        }

        public void Undo()
        {
            var newUser = (_mementos[_mementos.Count - 1].GetNewUser());
            //revert action
            _mementos.RemoveAt(_mementos.Count - 1);
        }
    }

    public class NewUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public NewUser Clone()
        {
            return MemberwiseClone() as NewUser;
        }
    }

    public class NewUserMemento //memento
    {
        private readonly NewUser _newUser;

        public NewUserMemento(NewUser newUser)
        {
            _newUser = newUser.Clone();
        }

        public NewUser GetNewUser()
        {
            return _newUser;
        }

    }
}
