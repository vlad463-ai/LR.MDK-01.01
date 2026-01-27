

namespace StudentHomoSapieNas
{
    class Student : HomaSappiens
    {
        private int numberTicket_;

        public Student(int numberTicket) : base("Никита", 20)
        {
            numberTicket_ = numberTicket;
        }

        public int GetNumberTicket
        {
            get { return numberTicket_; }
        }
        public override string ToString()
        {
            return base.ToString() + numberTicket_;
        }
    }
}
