namespace IdentityService.Services.Contracts.User
{
    public class UserJwtTokenDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        //public string Role { get; set; } = "User";

        //public string TelegramUserName { get; set; }

        public string Email { get; set; }
    }
}
