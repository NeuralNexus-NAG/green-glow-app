namespace UserManagementService.API.Controllers
{
    using UserManagementService.Business.Contracts;
    public class UserManagementController
    {
        private IUserService _userService;

        public UserManagementController(IUserService userService)
        {
            _userService = userService;
        }

        public IUserService UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }
    }
}