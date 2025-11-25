

using System.Collections.Generic;

namespace MenyClassesApplications
{
    class Storage //класс (место хранения склад)
    {
        private int identifier_; // идентификатор
        private string location_; // место локации
        private Dictionary<Product,int> Products_; // словарь с ключом Product(имя и цена) а значение это количество 
        
        public void  SetIdentifier(int identifier) // Метод добавления идентификатора
        {
            identifier_ = identifier;
        }
        public void SetLocation(string location) // мотод добавления локации
        {
            location_ = location;
        }
        public void SetProductQuantity(Product product, int quantity) // метод добавления product(имя и цена) и количества
        {
            Products_.Add(product, quantity);
        }
    }
}
