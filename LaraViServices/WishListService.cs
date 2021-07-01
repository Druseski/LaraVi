using LaraViRepositories.Interfaces;
using LaraViServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices
{
    public class WishListService: IWishListService
    {
        public readonly IWishListRepository _wishListRepository;

        public WishListService(IWishListRepository wishListRepository)
        {
            _wishListRepository = wishListRepository;
        }
    }
}
