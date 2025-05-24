using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("You open your eyes and find yourself face down on the beach of a large island, " +
                "the waves crashing on the shore not far off. A voice nearbay calls out\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\"Hey you! You're finally awake!\"\n");
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You sit up and look around. Somehow, opening your IDE has pulled you into Realms of C#, " +
                "a straange and mysterious land where it appears that you can use C# programing to solve problems." +
                "The man comes closer, examining you.\n");
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\"Are you okay? Can you speak?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("* Creating and runing a \"Hello, World!\" program seems like a good way to respond. *");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.ForegroundColor= ConsoleColor.Gray;

            Console.WriteLine("The man seems suprised that you've produced a working \"Hello, World!\" program.\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\"Been a whille since I saw somebody program like that around here. Do you know whay you're doing whith that? Can you make it do something besides just say 'Hello'?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Can you tell me where the hell we are?");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Th man, who tells you his name is Ritlin, asks you to follow him over to few of his friends, fishing on the dock.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ritlin: \"This one here has the marking of Programmer!\"");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The group looks at you with eyes widening and mouth agape.Ritlin truns to you and continues, ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\"I haven't seen nor heard tell of anybody who can wield that power un a million clock cycles of the CPU. " +
                "Nobody has been able to do that since the Uncoded One showed up in these lands.\"\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("He describes the shadowy and mysterious Uncoded One, an evil power that rots programs and prehaps even th world itself. " +
                "The Uncoded One's presence has prevented anybody from wielding the power of programing, the only thing that migth able to stop it. Yet somehow, " +
                "you have been able to grab hold of this power anyway. Ritlin's companions suddenly seem doubtful.\n" );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ratlin: \"Can you show them what you showed me? Use some of that programing of yours to make a program? Maybe something with more than one statment in it?\"");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("...");
            Console.WriteLine("\"Hello, my name Slim Shady\"");
            Console.WriteLine("\"I am not from this world and I don't have a slightest idea how I got here.\"");
            Console.WriteLine("\"Ritlin is rigth, I can you use the power of programing\"");
            Console.WriteLine("Can you please help me find way back home?");
        }
    }
}
