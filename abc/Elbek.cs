using System;
using System.Collections.Generic;
using System.Text;

namespace abc
{
    class Elbek
    {
        private int year = 13;

        //My year cannot be changed so set is private to other classes
        //But you can see my year))
        public int Year
        {
            get
            {
                return year;
            }
            private set
            {
                Year = value;
            }
        }

        private string fullname = "Elbek Rakhimjonov Rustamovich";

        //My full name cannot be changed so set is private to other classes
        //But you can see my full name too))
        public string fullName
        {
            get
            {
                return fullname;
            }
            private set
            {
                fullName = value;
            }
        }
        
        //ShowInfo funciton shows my Full name and year
        public void ShowInfo()
        {
            Console.WriteLine($"Full name: {fullName}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine();
        }
        
        //...
        public void AddYear(int add)
        {
            Year += add;
        }
    }
}
