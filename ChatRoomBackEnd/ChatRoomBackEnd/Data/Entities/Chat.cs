using System;

namespace ChatRoomBackEnd.Data.Entities
{
    public class Chat
    {
        public int Id { get; set; }
        
        public  DateTime CreatedAt { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public string Message { get; set; }
        
        public User User { get; set; }
        
        public string UserName { get; set; }
        
    }
}