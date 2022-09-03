using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class LogOutCommand : ICommand
    {
        private IMenuFactory menuFactory;
        private ISession session;

        public LogOutCommand(IMenuFactory menuFactory, ISession session)
        {
            this.menuFactory = menuFactory;
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
           this.session.Reset();

            return this.menuFactory.CreateMenu("Main Menu");
        }
    }
}
