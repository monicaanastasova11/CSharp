﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class SignUpCommand : ICommand
    {
        private IUserService userService;
        private IMenuFactory menuFactory;

        public SignUpCommand(IUserService userService, IMenuFactory menuFactory)
        {
            this.userService = userService;
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string username = args[0];
            string password = args[1];

            bool success = this.userService.TrySignUpUser(username, password);

            if(!success)
            {
                throw new ArgumentException("Invalid login!");
            }
            return this.menuFactory.CreateMenu("Main Menu");
        }
    }
}
