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
        private static CategoryModel _instance;

        public static CategoryModel GetCategoryModel()
        {
            if (_instance == null)
            {
                _instance = new CategoryModel();
                return _instance;
            }

            return _instance;
        }

        private CategoryModel()
        {
            Categories.Add(new Category()
            {
                Name = "Samochody osobowe",
                Description = "Pojazdy samochodowe przeznaczone konstrukcyjnie do przewozu nie więcej niż 9 osób łącznie z kierowcą oraz ich bagażu.",
                Subcategories = new Subcategory[]
                {
                    new Subcategory(){
                        Name = "Audi"
                    },
                    new Subcategory(){
                        Name = "BMW"
                    },
                    new Subcategory(){
                        Name = "Ford"
                    }
                }
            });
            Categories.Add(new Category() { 
                Name = "Samochody ciężarowe",
                Description = "Pojazdy samochodowe przeznaczone konstrukcyjnie do przewozu ładunków.",
                Subcategories = new Subcategory[]
                {
                    new Subcategory(),
                    new Subcategory(),
                    new Subcategory()

                }
            });
            Categories.Add(new Category() { 
                Name = "Motocykle",
                Description = "Jedno- lub dwuśladowe mechaniczne pojazdy drogowe o masie własnej do 400 kg",
                Subcategories = new Subcategory[]
                {
                    new Subcategory(),
                    new Subcategory(),
                    new Subcategory()

                }
            });
            Categories.Add(new Category() { 
                Name = "Samoloty",
                Description = "Załogowe bądź bezzałogowe statki powietrzne cięższe od powietrza (aerodyna)," +
                " utrzymujące się w powietrzu dzięki sile nośnej wytwarzanej za pomocą nieruchomych, w danych warunkach, względem statku skrzydeł.",
                Subcategories = new Subcategory[]
                {
                    new Subcategory(),
                    new Subcategory(),
                    new Subcategory()

                }
            });
        }
    }
}
