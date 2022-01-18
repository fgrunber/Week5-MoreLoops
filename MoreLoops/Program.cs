using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja parool;
            //Kui sisestatud kasutajatunnus on "admin" ja sisestatud parool on "admin1234";
            //Konsool kuvab "Tere tulemast!";
            //Muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuesti.";


            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string userPassword = Console.ReadLine();

            //AND (&&)
            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuest.");
            }

        }
    }
}
