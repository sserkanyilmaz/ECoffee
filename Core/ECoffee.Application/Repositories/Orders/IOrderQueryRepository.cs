﻿using ECoffee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoffee.Application.Repositories.Orders
{
    public interface IOrderQueryRepository : IQueryRepository<Order>
    {
    }
}
