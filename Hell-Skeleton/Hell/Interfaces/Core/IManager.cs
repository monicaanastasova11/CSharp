using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Interfaces.Core
{
    public interface IManager

    {
        string AddHero(IList<string> arguments);

        string AddCommonItem(IList<string> arguments);

        string AddRecipeItem(IList<string> arguments);

        string Inspect(IList<string> arguments);

        string Quit(IList<string> arguments);
    }
}
