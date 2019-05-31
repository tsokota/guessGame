using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Gamers;

namespace GameGuessUI
{
    class Program
    {
        static readonly Random random = new Random((int)DateTime.Now.Ticks);
        static void Main(string[] args)
        {
           
            int gamersNum = GetInt("Input number of players: ", 2, 8);

            Game.Game game = new Game.Game(gamersNum, random.Next(40, 141));

            for (int i = 0; i < gamersNum; i++)
            {
                game.AddNewGamer((GamerTypesEnum)(GetInt("Input type of players: ", 0, 4)),"Gamer"+1, random.Next(20, 65));
            }


            List<Gamer> win = game.StartPlay();

            foreach(var g in win)
                Console.WriteLine("Winner -> " + g.Name);

            Console.ReadKey();
        }

        static int GetInt(string str, int leftBorder, int rightBorder)
        {
            int res;
            while (true)
            {
                Console.Write(str);

                if (int.TryParse(Console.ReadLine(), out res) && res >= leftBorder && res <= rightBorder)
                    break;

                Console.WriteLine("Incorrect data! Repeat, please...");
            }

            return res;
        }


    }
}
