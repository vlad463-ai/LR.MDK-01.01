

namespace Task_1._1
{
    public class Employee // Сделал класс человек
    {
        private int ID_; // поля этого класса
        private string FullName_;
        private string Email_;


        public void SetID( int id) // Реализация трех функций для получения данных
        {
            ID_ = id;
        }
        public void SetFullName(string fullName)
        {
            FullName_ = fullName;
        }
        public void SetEmail(string email)
        {
            Email_ = email;
        }

      

    }


}
