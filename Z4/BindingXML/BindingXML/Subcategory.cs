using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingXML
{
    public class Subcategory
    {
        private string name;
        private string description;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
