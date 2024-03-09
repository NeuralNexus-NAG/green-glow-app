using UserManagementService.Shared;
using UserManagementService.Repository.Contracts;

namespace UserManagementService.Repository
{

    public class UserRepository : IUserRepository
    {
        private Dictionary<string, User> _users = new Dictionary<string, User>();

        public void AddUser(User user)
        {
            _users.Add(user.UserId, user);
        }

        public void UpdateUser(User user)
        {
            // implementation here
        }

        public void DeleteUser(User user)
        {
            // implementation here
        }

        public User GetUserById(string userId)
        {
            if (_users.ContainsKey(userId))
            {
                return _users[userId];
            }

            return null;
        }

        public List<User> GetAllUsers()
        {
            // implementation here
            throw new NotImplementedException();
        }
    }

}