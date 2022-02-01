namespace MyReceiptDemo.Dtos
{
    public class ItemDto
    {
         public int Id{get;set;}
        public string Name{get; set;}
        public int Quantity{get;set;}
        public decimal unitPrice{get;set;}
        public decimal Price{get;set;}
    }
    public class CreateItemRequestModel
    {
        
        public string Name{get; set;}
        public int Quantity{get;set;}
        public decimal unitPrice{get;set;}
        public decimal Price{get;set;}
    }
    public class UpdateItemRequestModel
    {
        public int Quantity{get;set;}
        public decimal unitPrice{get;set;}
        public decimal Price{get;set;}
    }
}