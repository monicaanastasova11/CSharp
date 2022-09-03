using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class AddPostMenuCommand : MenuCommand
    {
        public AddPostMenuCommand(IMenuFactory menuFactory) : base(menuFactory)
        {

        }
    }
}
