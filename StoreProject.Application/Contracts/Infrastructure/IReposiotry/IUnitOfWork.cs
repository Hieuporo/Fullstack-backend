using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.Infrastructure.IReposiotry
{
    public interface IUnitOfWork : IDisposable
    {
        ICouponRepository CouponRepository { get; }
        IBrandRepository BrandRepository { get; }
        ITagRepository TagRepository { get; }
        IShippingMethodRepository ShippingMethodRepository { get; }
        ICategoryRepository CategoryRepository { get; }


        Task Save();
    }
}
