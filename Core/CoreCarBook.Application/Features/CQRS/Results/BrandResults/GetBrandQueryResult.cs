﻿using CoreCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public int BrandID { get; set; }
        public string Name { get; set; } 
    }
}
