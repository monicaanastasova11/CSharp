﻿using Hell.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Miscellaneous
{
    public class RecipeItem : CommonItem, IRecipe
    {
        private IList<string> requiredItems;

        public RecipeItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus,
            int hitPointsBonus, int damageBonus, IList<string> requiredItems)
            : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
        {
            this.requiredItems = requiredItems;
        }

        public IList<string> RequiredItems => this.requiredItems;
    }
}
