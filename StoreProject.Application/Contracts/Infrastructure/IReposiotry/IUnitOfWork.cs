using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.Infrastructure.IReposiotry
{
    public interface IUnitOfWork : IDisposable
    {
        IBrandRepository BrandRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        ICartRepository CartRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICouponRepository CouponRepository { get; }
        IOrderItemRepository OrderItemRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductItemRepository ProductItemRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductTagRepository ProductTagRepository { get; }
        ITagRepository TagRepository { get; }
        IShippingMethodRepository ShippingMethodRepository { get; }


        Task Save();
    }
}
