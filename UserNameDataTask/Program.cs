using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm küsib kasutajal sisestada number 1-3
            //kui kasutaja valib 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimene täht
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    NumberOne(userName);
                    break;

                case 2:
                    NumberTwo(userName);
                    break;

                case 3:
                    NumberThree(userName);
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void NumberOne(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void NumberTwo(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void NumberThree(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
