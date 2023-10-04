﻿using StoreProject.Application.Contracts.Persistence;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Persistence.Repositories
{
    public class CouponRepository : GenericRepository<Coupon> , ICouponRepository { 

    }
}
