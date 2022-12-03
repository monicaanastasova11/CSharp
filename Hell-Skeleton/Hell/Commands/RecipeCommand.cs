using Hell.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Commands
{
    public class RecipeCommand
    {: AbstractCommand
{
    public RecipeCommand(IList<string> args, IManager manager)
        : base(args,
               manager)
        {
        }

        public override string Execute()
        {
            var result = this.Manager.AddRecipeItem(this.ArgsList);
            return result;
        }
    }
}

