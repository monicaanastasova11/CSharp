using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Heroes
{
    public class Wizard : AbstractHero
    {
        public Wizard(string name) : base(name, Constants.WizardStrengthConst, Constants.WizardAgilityConst, Constants.WizardIntelligenceConst, Constants.WizardHitPointsConst, Constants.WizardDamageConst)
        {
        }
    }
}
