using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanuse;
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taodelda";

            Console.WriteLine("Palun, sisestage oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            if (userAge < 18)
            {
                Console.WriteLine($"Oled {userAge} aastane, seega oled liiga noor, et juhilube saada.");
            }
            else if (userAge > 18)
            {
                Console.WriteLine($"Oled {userAge} aastane, seega oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine($"Palju õnne! Oledki {userAge} aastat vana, nüüd saad juhilube todelda.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
