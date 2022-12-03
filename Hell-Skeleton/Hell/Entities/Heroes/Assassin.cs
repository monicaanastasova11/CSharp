using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Heroes
{
    public class Assassin : AbstractHero
    {
        public Assassin(string name) : base(name, Constants.AssassinStrengthConst, Constants.AssassinAgilityConst, Constants.AssassinIntelligenceConst, Constants.AssassinHitPointsConst, Constants.AssassinDamageConst)
        {
        }
    }
}
