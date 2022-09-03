using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class CategoriesMenuCommand : MenuCommand
    {
       public CategoriesMenuCommand(IMenuFactory menuFactory) : base(menuFactory)
        {

        }
    }
}
