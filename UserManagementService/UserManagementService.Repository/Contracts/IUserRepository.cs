using UserManagementService.Shared;

namespace UserManagementService.Repository.Contracts
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetUserById(string userId);
        List<User> GetAllUsers();
    }
}