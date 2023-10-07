using Microsoft.AspNetCore.Http;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ICouponRepository _couponRepository;


        public UnitOfWork(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._httpContextAccessor = httpContextAccessor;
        }

        public ICouponRepository CouponRepository =>
           _couponRepository ??= new CouponRepository(_context);

        public IBrandRepository BrandRepository => throw new NotImplementedException();

        public ITagRepository TagRepository => throw new NotImplementedException();

        public IShippingMethodRepository ShippingMethodRepository => throw new NotImplementedException();

        public ICategoryRepository CategoryRepository => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            //var username = _httpContextAccessor.HttpContext.User.FindFirst(CustomClam)
            await _context.SaveChangesAsync();
        }
    }
}
