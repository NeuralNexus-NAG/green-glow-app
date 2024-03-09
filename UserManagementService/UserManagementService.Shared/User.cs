namespace UserManagementService.Shared
{
    public class User
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] UserImage { get; set; }
        public string Credentials { get; set; }
        public string UserRole { get; set; }
        public string GeneralInformation { get; set; }
    }
}
