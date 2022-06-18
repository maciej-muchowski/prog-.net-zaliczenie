﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingXML
{
    public class Category
    { 
        private string name;
        private string description;
        private Subcategory[] subcategories;
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Subcategory[] Subcategories { get => subcategories; set => subcategories = value; }
    }
}
