﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime RegisteredOn { get; set; }

        public int CategoryId { get; set; }
    }
}