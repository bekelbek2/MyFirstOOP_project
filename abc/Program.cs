using System;

namespace abc
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Calling person Elbek
            Elbek elbek = new Elbek();

            //Showing Elbek's info
            elbek.ShowInfo();
            
            //creating string that shows day
            string Today = DateTime.Now.ToString("dd'/'MM'/'yyyy");

            //You relaised why it's...
            if (Today == "05/01/2022")
            {
                elbek.AddYear(1);

                //Let's see what've been changed
                elbek.ShowInfo();
            }
        }
    }
}