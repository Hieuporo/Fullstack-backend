using AutoMapper;
using StoreProject.Application.DTOs.Brand;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Application.DTOs.CartItem;
using StoreProject.Application.DTOs.Category;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.DTOs.Order;
using StoreProject.Application.DTOs.OrderItem;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Application.DTOs.ProductTag;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Application.DTOs.Tag;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
            CreateMap<Coupon, CreateCouponDto>().ReverseMap();
            CreateMap<Coupon, UpdateCouponDto>().ReverseMap();

            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<ShippingMethod, ShippingMethodDto>().ReverseMap();
            CreateMap<ShippingMethod, CreateShippingMethodDto>().ReverseMap();
            CreateMap<ShippingMethod, UpdateShippingMethodDto>().ReverseMap();

            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<Tag, CreateTagDto>().ReverseMap();
            CreateMap<Tag, UpdateTagDto>().ReverseMap();

            CreateMap<CartItem, CartItemDto>().ReverseMap();
            CreateMap<CartItem, CreateCartItemDto>().ReverseMap();
            CreateMap<CartItem, UpdateCartItemDto>().ReverseMap();

            CreateMap<Cart, CartDto>()
                .ForMember(dest => dest.CartItems, opt => opt.MapFrom(src => src.CartItems.Select(item => new CartItemDto
                {
                    Id = item.Id,
                    ProductItemId = item.ProductItemId,
                    CartId = item.CartId,
                    Quantity = item.Quantity,
                })));

            CreateMap<CartDto, Cart>();



            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();


            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<OrderItem, CreateOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, UpdateOrderItemDto >().ReverseMap();

            CreateMap<ProductTag, ProductTagDto>().ReverseMap();
            CreateMap<ProductTag, CreateProductTagDto>().ReverseMap();
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>()
              .ForMember(dest => dest.ProductItems, opt => opt.MapFrom(src => src.ProductItems.Select(item => new ProductItemDto
              {
                  Id = item.Id,
                  ProductId = item.ProductId,
                  Name = item.Name,
                  ImageUrl = item.ImageUrl,
                  QuantityInStock = item.QuantityInStock,
                  Price = item.Price,
              })));

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();

            CreateMap<ProductItem, ProductItemDto>().ReverseMap();
            CreateMap<ProductItem, CreateProductItemDto>().ReverseMap();
            CreateMap<ProductItem, UpdateProductItemDto>().ReverseMap();
        }
    }
}
