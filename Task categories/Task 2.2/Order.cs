

using System;

namespace Task_2._2
{
    public class Order
    {
        private int OrderId_;               // ID заказа
        private double TotalAmount_;       // Общая сумма
        private int Weight_;            // Вес
        private string DestinationCountry_; // Страна доставки
        private string PaymentMethod_;      // Способ оплаты

        public int GetOrderId()
        {
            return OrderId_;
        }
        public double GetTotalAmount()
        {
            return TotalAmount_;
        }
        public int GetWeight()
        {
            return Weight_;
        }
        public string GetDestinationCountry()
        {
            return DestinationCountry_;
        }
        public string GetPaymentMethod()
        {
            return PaymentMethod_;
        }

        public void SetOrderId(int OrderId)
        {
            OrderId_ = OrderId;
        }
        public void SetTotalAmount(double TotalAmount)
        {

            TotalAmount_ = TotalAmount;
        }
        public void SetWeight(int Weight)
        {
            Weight_ = Weight;
        }
        public void SetDestinationCountry(string DestinationCountry)
        {
            DestinationCountry_ = DestinationCountry;
        }
        public void SetPaymentMethod(string PaymentMethod)
        {
            PaymentMethod_ = PaymentMethod;
        }

        public void ShowOrder()
        {
            Console.WriteLine($"Заказ номер: {OrderId_}");
            Console.WriteLine($"Сумма: {TotalAmount_} руб.");
            Console.WriteLine($"Вес: {Weight_} кг");
            Console.WriteLine($"Страна: {DestinationCountry_}");
            
            
        }


    }
}
