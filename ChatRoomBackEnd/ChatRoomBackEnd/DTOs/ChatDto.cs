using System;

namespace ChatRoomBackEnd.DTOs
{
    public class ChatDto
    {
        public int Id {get; set;}
        
        public string UserName {get; set;}
        
        public string Message {get; set;}
        
        public DateTime DateSent {get; set;}
    }
    
    public class CreateChatDto
    {
        public string UserName {get; set;}
        
        public string Message {get; set;}
    }
}