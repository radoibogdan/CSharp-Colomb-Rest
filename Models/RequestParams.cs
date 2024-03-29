﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Models
{
    // Parameter names that are allowed
    public class RequestParams
    {
        const int maxPageSize = 50;
        // Default page number
        public int PageNumber { get; set; } = 1;
        // Default page size
        private int _pageSize = 10;

        // PageSize.set(50) => 50 = value
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
