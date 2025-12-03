

namespace Task_1._1
{
    public class FixedSalaryEmployee // класс (сотрудник с фиксированной зарплатой)
    {
        private Employee Employee_;
        private double FixedSalary_;

        public void SetEmployee(Employee Employees) // два метода для получения данных
        {
            Employee_ = Employees;
        }
        public void SetFixedSalary(double fixedSalary)
        {
            FixedSalary_ = fixedSalary;
        }
        public double CalculateSalary() // подсчет суммы
        {
            return FixedSalary_;
        }
    }

}
