using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class PurchaseViewModel
    {
        [Required(ErrorMessage = "Not valid name")]
        public string Person { get; set; }
        
        [Required(ErrorMessage = "Not valid address")]
        public string Address { get; set; }
        
        public int ProductId { get; set; }
    }
}