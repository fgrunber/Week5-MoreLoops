using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja parool;
            //Kui sisestatud kasutajatunnus on "admin" ja sisestatud parool on "admin1234";
            //Konsool kuvab "Tere tulemast!";
            //Muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuesti.";

            //OR (või) ||

            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false

            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
