using Forum.App.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Forum.App.Factories
{
    public class MenuFactory : IMenuFactory
    {
        private IServiceProvider serviceProvider;

        public MenuFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public IMenu CreateMenu(string menuName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            Type menuType = types.FirstOrDefault(t => t.Name == menuName );

            if (menuType == null)
            {
                throw new InvalidOperationException("Menu not found!");
            }
            if (!typeof(IMenu).IsAssignableFrom(menuType))
            {
                throw new InvalidOperationException($"{menuType}is not a menu!");
            }
            ParameterInfo[] ctorParams = menuType.GetConstructors().First().GetParameters();
            object[] args = new object[ctorParams.Length];

            for(int i = 0; i < ctorParams.Length; i++)
            {
                args[i] = this.serviceProvider.GetService(ctorParams[i].ParameterType);
            }
           
            IMenu menu = (IMenu)Activator.CreateInstance(menuType, args);
            return menu;
        }
    }
}
