
using UserManagementService.Shared;
namespace UserManagementService.Business.Contracts
{
    public interface IUserService
    {
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(string userId);
        User GetUser(string userId);
        List<User> ListUsers();
    }
}