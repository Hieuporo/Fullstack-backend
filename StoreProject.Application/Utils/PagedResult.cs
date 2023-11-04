﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Utils
{
    public class PagedResult
    {
        public object Items { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPage { get; set; }
    }
}
