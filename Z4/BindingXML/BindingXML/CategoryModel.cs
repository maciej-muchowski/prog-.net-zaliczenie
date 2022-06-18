using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingXML
{
    internal class CategoryModel
    {
        public ObservableCollection<Category> Categories { get; } = new ObservableCollection<Category>();

        public CategoryModel()
        {
            Categories.Add(new Category() { Name = "Samochody osobowe" });
            Categories.Add(new Category() { Name = "Samochody ciężarowe" });
            Categories.Add(new Category() { Name = "Motocykle" });
            Categories.Add(new Category() { Name = "Samoloty" });
        }
    }
}
