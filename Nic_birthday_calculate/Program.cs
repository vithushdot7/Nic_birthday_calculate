using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nic_birthday_calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the NIC No : ");
            string nic = Console.ReadLine();
            nicInfo(nic);
            

            Console.ReadKey();
        }

        public static void nicInfo(string nicNo)
        {
            string gen;
            string month = "";
            int day = 0;

            string year = nicNo.Substring(0, 2);
            Console.WriteLine("Birth Year : " + "19" + year);

            string genderValue = nicNo.Substring(2, 3);
            int gender = Int16.Parse(genderValue);

            if (gender < 500)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
                gender -= 500;
            }


            if (gender > 335)
            {
                month = "December";
                day = gender - 335;
            }
            else if (gender > 305)
            {
                day = gender - 305;
                month = "November";
            }
            else if (gender > 274)
            {
                day = gender - 274;
                month = "October";
            }
            else if (gender > 244)
            {
                day = gender - 244;
                month = "September";
            }
            else if (gender > 213)
            {
                day = gender - 213;
                month = "Auguest";
            }
            else if (gender > 182)
            {
                day = gender - 182;
                month = "July";
            }
            else if (gender > 152)
            {
                day = gender - 152;
                month = "June";
            }
            else if (gender > 121)
            {
                day = gender - 121;
                month = "May";
            }
            else if (gender > 91)
            {
                day = gender - 91;
                month = "April";
            }
            else if (gender > 60)
            {
                day = gender - 60;
                month = "March";
            }
            else if (gender < 32)
            {
                month = "January";
                day = gender;
            }
            else if (gender > 31)
            {
                day = gender - 31;
                month = "Febuary";
            }

            Console.WriteLine("Person Gender is : " + gen);
            Console.WriteLine("Person Birth Month is : " + month);
            Console.WriteLine("Person Gender is : " + day);
        }
    }
}
