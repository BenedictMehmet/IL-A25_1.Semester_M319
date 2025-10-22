using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW43_25
{
    internal class AdventureGame
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Willkommen zum AdventureGame");
            Console.WriteLine("Gib deinen Namen ein: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Wähle deinen Charakter (Warrior, Wizard, Archer)");
            string charakterTyp = Console.ReadLine();

            Console.WriteLine($"Du, {playerName} der {charakterTyp} findest dich selber am Ende an einem dunklen Ort");
            Console.WriteLine("Willst du in den Wald gehen oder im Zelt bleiben? (Wald/Zelt)");

            string choice1 = Console.ReadLine();

            if(choice1.ToLower() == "wald")
            {
                Console.WriteLine("Du hast den Wald erreicht");
            } else
            {
                Console.WriteLine("Du bist im Zelt geblieben und wartest bis Tagesanbruch.");
            }

            bool gameContinues = true;

            while(gameContinues)
            {
                Console.WriteLine("Willst du nach rechts oder links? (links/rechts)");
                string direction = Console.ReadLine();

                if(direction.ToLower() == "links")
                {
                    Console.WriteLine("Du hast eine Schatztruhe gefunden");
                    gameContinues = false;
                }
                else
                {
                    Console.WriteLine("Ein Bär steht vor dir.");
                    Console.WriteLine("Willst du kämpfen oder weglaufen? (kämpfen/weglaufen)");
                    string choice2 = Console.ReadLine();
                    if(choice2.ToLower() == "kämpfen")
                    {
                        Random rdm = new Random();
                        int glück = rdm.Next(1, 11);
                        Console.WriteLine("Gib eine Zahl ein.");
                        string zahl = Console.ReadLine();
                        int eingabe = Convert.ToInt32(zahl);

                        if (eingabe > glück)
                        {
                            Console.WriteLine("Du hast den Bär besiegt!");
                        }
                        else
                        {
                            Console.WriteLine("Du hast leider verloren");
                            gameContinues = false;
                        }
                    }
                }
            }
        }
    }
}
