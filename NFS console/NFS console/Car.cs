

namespace NFS_console
{
     public class Car
     {
        private string model_;
        private int speed_;

        /// Получение модели
        public string GetModel()
        {
            return model_;
        }
        public int GetSpeed()
        {
            return speed_;
        }

        ///Задание модели
        public void SetModel(string model)
        {
            model_ = model;
        }
        public void SetSpeed(int speed)
        {
            speed_ = speed;
        }

     }
     
}
