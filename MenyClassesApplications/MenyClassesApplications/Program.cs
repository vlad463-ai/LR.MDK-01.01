
namespace MenyClassesApplications
{
    class Program
    {
        static void Main()
        {
            Storage storage = new Storage(); // Создали объект экземпляра Storage
            storage.SetIdentifier(123);
            storage.SetLocation("город Торжок, Студенческая 3");
            
            Product mercedesBens = new Product(); // Создали объект mercedesBens
            mercedesBens.SetName("Мерседес Бенс");
            mercedesBens.SetPrice(1000000);

            Product UAZ = new Product(); // Создали объект UAZ
            UAZ.SetName("Уазик");
            UAZ.SetPrice(10000000);

            storage.SetProductQuantity(mercedesBens, 2); //Добавили в словарь 2 записи
            storage.SetProductQuantity(UAZ, 5);

            storage.Print();
            double total = storage.PrintAllMoney(); //Сделал вывод на консоль двух функций для печати





        }
    }
}
