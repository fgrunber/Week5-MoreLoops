using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja parool;
            //Kui sisestatud kasutajatunnus on "admin" ja sisestatud parool on "admin1234";
            //Konsool kuvab "Tere tulemast!";
            //Muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuesti.";
            //Kasutajal on kolm katset

            
            int i = 0;
           

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool");
                string userPassword = Console.ReadLine();
                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või parool. Proovi uuesti, {3 - i} katset on jaanud");
                }
            }
        }
    }
}
