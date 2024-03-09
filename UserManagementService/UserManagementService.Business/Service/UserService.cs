using UserManagementService.Business.Contracts;
using UserManagementService.Shared;
using UserManagementService.Repository.Contracts;

namespace UserManagementService.Business
{

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateUser(User user)
        {
            user.UserId = Guid.NewGuid().ToString();
            this._userRepository.AddUser(user);
            return user;
        }

        public User UpdateUser(User user)
        {
            // implementation here
            throw new NotImplementedException();
        }

        public void DeleteUser(string userId)
        {
            // implementation here
        }

        public User GetUser(string userId)
        {
            // implementation here
            if (int.Parse(userId) <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be greater than 0.");
            }

            var user = _userRepository.GetUserById(userId);

            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {userId} not found.");
            }

            return user;
        }

        public List<User> ListUsers()
        {
            // implementation here
            throw new NotImplementedException();
        }
    }

}