using System;

namespace FirstMVCApp.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        
        public string Person { get; set; }
        
        public string Address { get; set; }
        
        public int ProductId { get; set; }
        
        public DateTime Date { get; set; }
    }
}