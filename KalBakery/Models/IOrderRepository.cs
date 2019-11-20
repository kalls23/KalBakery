using System;
namespace KalBakery.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
