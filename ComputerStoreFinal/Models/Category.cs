﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Part> Parts { get; set; }
    }
}