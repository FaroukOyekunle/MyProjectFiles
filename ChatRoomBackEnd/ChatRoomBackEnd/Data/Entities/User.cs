using System.Collections.Generic;

namespace ChatRoomBackEnd.Data.Entities
{
    public class User
    {
        public string UserName { get; set; }
        
        public string Password { get; set; }
        
        public List<Chat> Chats { get; set; }

    }
}