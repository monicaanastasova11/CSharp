using Forum.App.Contracts;
using Forum.Data;
using Forum.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.Services
{
    public class UserService : IUserService
    {
        private ForumData forumData;
        private ISession session;

        public UserService(ForumData forumData, ISession session)
        {
            this.forumData = forumData;
            this.session = session;
        }

        public User GetUserById(int userId)
        {
            var user = this.forumData.Users.FirstOrDefault(u => u.Id == userId);

            return user;
        }

        public string GetUserName(int userId)
        {
            var username = this.forumData.Users.FirstOrDefault(u => u.Id == userId).Username;

            return username;
        }

        public bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            User user = this.forumData.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                return false;
            }

            this.session.Reset();
            this.session.LogIn(user);

            return true;
        }

        public bool TrySignUpUser(string username, string password)
        {
            bool ValidUsername = !string.IsNullOrEmpty(username) && username.Length > 3;
            bool ValidPassword = !string.IsNullOrWhiteSpace(password) && password.Length > 3;

            if (!ValidUsername && ValidPassword)
            {
                throw new ArgumentException("The username and the password must be longer than 3 symbols! ");
            }

            bool userAlreadyExists = forumData.Users.Any(u => u.Username.Equals (username));
            if (userAlreadyExists)
            {
                throw new ArgumentException("The username is taken!");
            }

            int userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
            User user = new User(userId, username, password);
            forumData.Users.Add(user);
            forumData.SaveChanges();

            this.TryLogInUser(username, password);
            return true;
        }
    }
}
