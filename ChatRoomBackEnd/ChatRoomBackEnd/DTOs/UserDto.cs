namespace ChatRoomBackEnd.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
    public class LoginUserResponseDto
    {
        public string Username { get; set; }
    }
}