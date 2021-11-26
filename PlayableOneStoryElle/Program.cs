using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayableOneStoryElle
{
    class Program
    {
        static string[] story = new string[100];
        static string[] page;
        static int currentPage = 0;
        static bool gameEnd = false;

        static void Main(string[] args)
        {
            GameLoop();

        }

        static void Story()
        {
            story[0] = "MONSTEROUS HUNGERS_BEGIN!_BEGIN!_1_1";
            story[1] = "You are in a dark, heavily wooded area. The smell of pine mingles with damp moss. There are footsteps behind you, growing ever closer. In front of you are two paths, barely visible in the pale moonlight.--> The path to your right is lined with faintly glowing mushrooms.< --The path to your left is lined with thorn bushes, their tendrils seeming to grasp at your ankles as if they were alive. _A: Right_B: Left _2 _3";
            story[2] = "As you continue to the right, the footsteps behind you begin to slow.The forest ambience of chirping crickets and rustling bushes begins to fade to silence. _A: Slow Down _B: Keep Running _4 _5";
            story[3] = "You sprint to the left, thorns whipping past your ankles. The footsteps following you become louder. The creature is gaining on you. Its breath is hot on your neck. _A: Continue straight ahead _B: Dive into the brush _6 _7";
            story[4] = "You slow down, relaxing. As you do, you step on a twig. With a loud snap, you realise you've compromised your position. A growl sounds from directly behind you. _A: uh oh _B: uh oh _8 _8";
            story[5] = "You continue running. The sky begins to lighten as the wooded area clears. _A: oh? _B: oh? _9 _9";
            story[6] = "You try o outrun the beast, but thorns tear at your ankles. They wrap around your shins, stopping you in your tracks. You feel its rancid breath envelop you. _A: uh oh... _B: uh oh... _8 _8";
            story[7] = "Diving into the bushes, you duck and roll. The beast roars in fury, getting stuck in the brambles and spines. You are small enough to worm out of the thorns and run. You run for what seems like hours until a hint of light catches your eye. With a final sprint, you can see an exit. _A: ...yes _B: ...yes _9 _9";
            story[8] = "The beast has caught up with you, and before you can turn to face it, it tears your head from your shoulders.";
            story[9] = "You escape the forest. You live to fight another day.";
            page = story[currentPage].Split('_');

            // page[0] = "hello"
            // page[1] = "option"

            int parse = Int32.Parse(page[3]);
            int parseTwo = Int32.Parse(page[4]);

            Console.WriteLine(page[0]);
            Console.WriteLine(page[1]);
            Console.WriteLine(page[2]);

            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);

            if (readKeyInput.Key == ConsoleKey.A)
            {
                currentPage = parse;
                // get the page number
                // write it out
            }
            if (readKeyInput.Key == ConsoleKey.B)
            {
                currentPage = parseTwo;
            }

        }
        static void GameLoop()
        {
            while (gameEnd == false)
            {
                Story();
            }
            if (gameEnd == true)
            {
                Console.ReadKey(true);
            }
        }
    }
}
