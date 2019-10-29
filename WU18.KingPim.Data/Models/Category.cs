﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WU18.KingPim.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
    }
}