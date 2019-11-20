using System;
namespace KalBakery.Models
{
    public class OrderDetail
    { 
       public int OrderDetailId { get; set; }
       public int OrderId { get; set; }
       public int CakeId { get; set; }
       public int Amount { get; set; }
       public decimal Price { get; set; }
       public Cake Cake { get; set; }
       public Order Order { get; set; }
        
    }
}
