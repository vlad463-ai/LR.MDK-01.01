

using System;

namespace Task_2._2
{
    public class DeliveryCalculator // создал класс DeliveryCalculator
    {
        static public void deliveryCalculator(Order order) //реализовал функцию для расчета доставки
        {
            double cost = 200;
            cost += order.GetWeight() * 40;
            if (order.GetDestinationCountry() == "Россия")
            {
                cost += 0;
                Console.WriteLine("Россия - доставка дешевая");
            }
            else if (order.GetDestinationCountry() == "Беларусь" || order.GetDestinationCountry() == "Казахстан")
            {
                cost += 800;
            }
            Console.WriteLine($"Итого доставка: {cost} руб.");
            Console.WriteLine($"Всего к оплате: {order.GetTotalAmount() + cost} руб.");
        }
      
    }
}
