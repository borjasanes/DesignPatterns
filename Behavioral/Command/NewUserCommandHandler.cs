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
    }

    public class NewUserCommandHandler : ICommandHandler<NewUser>
    {
        public void Handle(NewUser command)
        {
            //operation
        }
    }

    public class NewUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
