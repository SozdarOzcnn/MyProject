﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer :IEntitiy
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompantName { get; set; }
        public string City { get; set; }
    }
}
