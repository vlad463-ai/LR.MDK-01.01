

using System.Runtime.InteropServices;

namespace StudentHomoSapieNas
{
    class HomaSappiens
    {
        protected string name_;
        protected int age_;

        public HomaSappiens (string name, int age)
        {
            name_ = name;
            age_ = age;
        }

        public override string ToString()
        {
            return $"{name_},{age_} лет ";
        }
    }

}
