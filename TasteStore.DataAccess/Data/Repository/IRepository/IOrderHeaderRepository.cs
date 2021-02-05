﻿using System;
using System.Collections.Generic;
using System.Text;
using TasteStore.DataAccess.Data.Repository.Interfaces;
using TasteStore.Models;

namespace TasteStore.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
