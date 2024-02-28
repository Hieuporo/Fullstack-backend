using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Infrastructure.Data;


namespace StoreProject.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
		private IDbContextTransaction _objTran;

		public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

		private ICouponRepository _couponRepository;

		public ICouponRepository CouponRepository =>
           _couponRepository ??= new CouponRepository(_context);

        private IBrandRepository _brandRepository;
        public IBrandRepository BrandRepository =>
            _brandRepository ??= new BrandRepository(_context);

        private IShippingMethodRepository _shippingMethodRepository;
        public IShippingMethodRepository ShippingMethodRepository =>
            _shippingMethodRepository ??= new ShippingMethodRepository(_context);

        private ICategoryRepository _categoryRepository;
        public ICategoryRepository CategoryRepository =>
            _categoryRepository ??= new CategoryRepository(_context);

        private ICartItemRepository _cartItemRepository;
        public ICartItemRepository CartItemRepository =>
            _cartItemRepository ??= new CartItemRepository(_context);

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

        private ICartRepository _cartRepository;
        public ICartRepository CartRepository =>
         _cartRepository ??= new CartRepository(_context);

		public void CreateTransaction()
		{
			_objTran = _context.Database.BeginTransaction();
		}

	
		public void Commit()
		{
			_objTran.Commit();
		}

		public void Rollback()
		{
			_objTran.Rollback();
			_objTran.Dispose();
		}



		private bool disposed = false;

		protected void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
