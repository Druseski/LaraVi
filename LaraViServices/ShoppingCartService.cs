using LaraViRepositories.Interfaces;
using LaraViServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices
{
    public class ShoppingCartService: IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }
    }
}
