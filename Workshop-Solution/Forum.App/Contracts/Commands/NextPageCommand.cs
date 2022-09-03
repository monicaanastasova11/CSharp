using Forum.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{


    public class NextPageCommand : ICommand
    {

        private ISession session;

        public NextPageCommand(ISession session)
        {
            this.session = session;
        }
       

        public IMenu Execute (params string[] args)
        {
            IMenu currentmenu = this.session.CurrentMenu;
            if(currentmenu is IPaginatedMenu paginatedMenu)
            {
                paginatedMenu.ChangePage();
                
            }
            return currentmenu;
        }
    }
}
