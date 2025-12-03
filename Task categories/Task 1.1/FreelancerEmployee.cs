

namespace Task_1._1
{
    public class FreelancerEmployee // класс (фрилансер)
    {
        private Employee Employee_; // поля класса 
        private double ProjectPayment_;
        private double TaxPercent_;

        public void SetProjectPayment(double ProjectPayment) // три метода для получения значений 
        {
            ProjectPayment_ = ProjectPayment;
        }
        public void SetTaxPercent(double TaxPercent)
        {
            TaxPercent_ = TaxPercent;
        }
        public void SetEmployee(Employee Employees)
        {
            Employee_ = Employees;
        }
        public double CalculateSalary() // метод для получения зарплаты
        {
            double taxAmount = ProjectPayment_ * (TaxPercent_ / 100);
            return ProjectPayment_ - taxAmount;
        }
    }
}
