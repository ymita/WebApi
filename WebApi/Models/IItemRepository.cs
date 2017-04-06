﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
    }
}