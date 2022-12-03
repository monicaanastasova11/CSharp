using Hell.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hell.Commands
{
    public abstract class AbstractCommand:ICommand
    {
        

    private IList<string> args;
        private IManager manager;

        public AbstractCommand(IList<string> args, IManager manager)
        {
            this.args = args;
            this.manager = manager;
        }

        protected IList<string> ArgsList => this.args;

        protected IManager Manager => this.manager;
    }
}
        

