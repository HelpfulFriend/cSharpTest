using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoredProgramming
{
    class FirstProgram
    {
        //flokkurin og øll nøvnini
        public string[] flokkur = new string[21]
        { "Joan", "Knut", "Mary", "Jørmund", "Sanny",
                "Anna Kristina","Denis", "Høgni", "Jakup", "Robert",
                "Elsa", "Hanna", "Boas", "Djoni", "Erla", "Maria Muller",
                "Maria Gøthe", "Marius", "Tummas", "Bjørt", "Nora" };

        //create a random object
        Random navn = new Random();

       public int index;

       


        //strings til ja ella nei
        string answer;
        string HiddenAnswer;


        //update groups
        public static int Updater() {

            Main();

            return 0;

        }


       public void Main()
        {
            index = navn.Next(flokkur.Length);

            //spyr um navn
            Console.WriteLine("Hey, hvat er títt navn?");
            //inn tekur navn
            var name = Console.ReadLine();
            //sigur dato
            var date = DateTime.Now;
            //skrivar ut navn og dato
            Console.WriteLine($"\nHey, {name}, Í dag er {date:d}. Klokkan er {date:t}!");
            Console.WriteLine("Trýst á enter til at fara víðari");
            Console.ReadKey();
            //spyr um at spæla eitt spæl
            Console.WriteLine("skulu vit spæla eitt spæl?  Svara ja ella nei");
            answer = Console.ReadLine();

            if (answer.Contains("ja"))
            {
                //sigur ja til at spæla
                Console.WriteLine("vit fara at spæla heingja mann, við bara at brúka bara  nøvn í T1As flokkinum (tí vit hava tvær sum eita maria so er tað Maria Gøthe og Maria Muller)");
                Console.ReadKey();






                for (int x = 0; x < name.Length; x++)
                { HiddenAnswer += "*"; }

                //sigur hvør tað er
                Console.WriteLine($"persónurin tú skal finna er {flokkur[index]}");
                //sigur við stjórnum
                Console.WriteLine("persónurin tú skal finna er ");
                Console.ReadKey();

            }
            else
            {
                //sigur nei til at spæla
                Console.WriteLine("Tú hevur svarað nei, hettar lukkar nú");
                Console.ReadKey();
            }







            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
