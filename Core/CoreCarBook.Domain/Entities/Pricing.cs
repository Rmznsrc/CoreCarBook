﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
        public List<CarPricing>carPricings { get; set; }
    }
}
