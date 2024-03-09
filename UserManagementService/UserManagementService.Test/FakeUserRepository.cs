using System;
using System.Collections.Generic;
using UserManagementService.Repository.Contracts;
using UserManagementService.Shared;

namespace UserManagementService.Tests
{
    public class FakeUserRepository : IUserRepository
    {
        private Dictionary<string, User> _users = new Dictionary<string, User>();

        public void AddUser(User user)
        {
            _users.Add(user.UserId, user);
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(string userId)
        {
            if (_users.ContainsKey(userId))
            {
                return _users[userId];
            }

            return null;
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}