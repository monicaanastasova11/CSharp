using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Heroes
{
    public class Barbarian : AbstractHero
    {
        public Barbarian(string name) : base(name, Constants.BarbarianStrengthConst, Constants.BarbarianAgilityConst, Constants.BarbarianIntelligenceConst, Constants.BarbarianHitPointsConst, Constants.BarbarianDamageConst)
        {

        }
    }
}
