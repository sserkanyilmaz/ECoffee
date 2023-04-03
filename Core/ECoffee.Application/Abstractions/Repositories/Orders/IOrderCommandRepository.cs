﻿using ECoffee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoffee.Application.Abstractions.Repositories.Orders
{
    public interface IOrderCommandRepository:ICommandRepository<Order>
    {
    }
}
