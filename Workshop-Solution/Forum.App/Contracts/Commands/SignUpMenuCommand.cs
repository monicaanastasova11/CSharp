using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class SignUpMenuCommand : MenuCommand
    {
        public SignUpMenuCommand(IMenuFactory menuFactory) : base(menuFactory)
        {

        }
    }
}
