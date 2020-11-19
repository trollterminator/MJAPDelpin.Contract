﻿using MJAPDelpin.Contract.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MJAPDelpin.Contract.Application.Interface
{
    public interface IStorageQuery
    {
        public Order GetOrder(int id);
        public List<Order> GetAllOrders();
        
    }
}
