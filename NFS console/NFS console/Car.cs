

namespace NFS_console
{
     public class Car
     {
        private string model_;
        private int speed_;

        public string GetModel()
        {
            return model_;
        }

        public string GetSpeed()
        {
            return speed_;
        }

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
