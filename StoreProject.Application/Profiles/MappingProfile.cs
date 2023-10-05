using AutoMapper;
using StoreProject.Application.DTOs.Coupon;
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

        }
    }
}
