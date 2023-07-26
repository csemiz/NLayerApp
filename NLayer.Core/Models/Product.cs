﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }//Category'den Id ürettiğimizde EF-Core Foregn Key olarak algiliyor.
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}