using System;
using System.Collections.Generic;
using System.Text;
using Behavioral.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Behavioral.Command
{
    [TestClass]
    public class CommandHandlerTest
    {

        [TestMethod]
        public void Given_NewUserCommand_Should_CreateNewUser()
        {
            var sut = new NewUserCommandHandler();

            sut.Handle(new NewUser
            {
                Name = "potato"
            });

            sut.Handle(new NewUser
            {
                Name = "potato",
                Surname = "potato surname",
            });

            sut.Undo();
        }
    }
}
