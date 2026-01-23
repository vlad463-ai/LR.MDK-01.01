

using System.Windows.Forms;

namespace ConstWinForms
{
    public class Student
    {
        private string name_;
        private int age_;
        private double avgScore_;
        private int numberID_;
        private string photo_;

        public Student(string name, int age, double avgScore, int numberID, string Photo )
        {
            name_ = name;
            age_ = age;
            avgScore_ = avgScore;
            numberID_ = numberID;
            photo_ = Photo;
        }

        public string Name
        {
            get { return name_; }
        }
        public int Age
        {
            get { return age_; }
        }
        public double AvgScore
        {
            get { return avgScore_; }
        }
        public int NumberID
        {
            get { return numberID_; }
        }
        public string Photo
        {
            get { return photo_; }
        }


    }
}
