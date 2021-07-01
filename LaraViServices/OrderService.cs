using LaraViRepositories.Interfaces;
using LaraViServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
