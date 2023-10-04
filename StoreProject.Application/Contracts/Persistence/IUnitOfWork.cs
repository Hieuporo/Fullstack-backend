using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICouponRepository CouponRepository { get; }
        Task Save();
    }
}
