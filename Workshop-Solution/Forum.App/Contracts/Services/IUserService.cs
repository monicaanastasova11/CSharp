namespace Forum.App.Contracts
{
	using DataModels;
    using Forum.App.Models;
    using Forum.Data;
    using System;
    using System.Linq;
    

    public interface IUserService


    {

        bool TrySignUpUser(string username, string password);


        bool TryLogInUser(string username, string password);
        
        

        string GetUserName(int userId);


        User GetUserById(int userId);
        
    }
}
