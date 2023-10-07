using Microsoft.AspNetCore.Http;
using StoreProject.Application.Constants;
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

        private IBrandRepository _brandRepository;
        public IBrandRepository BrandRepository =>
            _brandRepository ??= new BrandRepository(_context);

        private ITagRepository _tagRepository;
        public ITagRepository TagRepository =>
            _tagRepository ??= new TagRepository(_context);

        private IShippingMethodRepository _shippingMethodRepository;
        public IShippingMethodRepository ShippingMethodRepository =>
            _shippingMethodRepository ??= new ShippingMethodRepository(_context);

        private ICategoryRepository _categoryRepository;
        public ICategoryRepository CategoryRepository =>
            _categoryRepository ??= new CategoryRepository(_context);

        private ICartItemRepository _cartItemRepository;
        public ICartItemRepository CartItemRepository =>
            _cartItemRepository ??= new CartItemRepository(_context);

        private ICartRepository _cartRepository;
        public ICartRepository CartRepository =>
            _cartRepository ??= new CartRepository(_context);

        private IOrderItemRepository _orderItemRepository;
        public IOrderItemRepository OrderItemRepository =>
            _orderItemRepository ??= new OrderItemRepository(_context);

        private IOrderRepository _orderRepository;
        public IOrderRepository OrderRepository =>
            _orderRepository ??= new OrderRepository(_context);

        private IProductItemRepository _productItemRepository;
        public IProductItemRepository ProductItemRepository =>
            _productItemRepository ??= new ProductItemRepository(_context);

        private IProductRepository _productRepository;
        public IProductRepository ProductRepository =>
            _productRepository ??= new ProductRepository(_context);

        private IProductTagRepository _productTagRepository;
        public IProductTagRepository ProductTagRepository =>
            _productTagRepository ??= new ProductTagRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            //var username = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid);
            await _context.SaveChangesAsync();
        }
    }
}
