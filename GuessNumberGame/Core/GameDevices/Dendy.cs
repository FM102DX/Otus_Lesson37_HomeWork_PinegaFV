using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core.GameSettings;

namespace GuessNumberGame.Core.GameDevices
{
    public class Dendy : GameDeviceBase, INumbericGameDevice
    {
        public override string Name { get; set; } = "Dendy";

        public override  void Run(INumbericGame<INumbericGameSettings> game)
        {
            ConsoleWriter.WriteYellow("");
            ConsoleWriter.WriteWithColor("***** Привет, с вами игровая консоль Dendy! *****", ConsoleColor.DarkBlue);

            while (true)
            {
                int menuItem = ShowMenu();

                switch (menuItem)
                {
                    case 1:
                        game.Start();
                        break;

                    case 2:
                        Console.WriteLine("Спасибо за игру, хорошего дня!");
                        return;
                }
            }
        }

        private static int ShowMenu()
        {
            bool correctInput = false;
            int rez = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                ConsoleWriter.WriteGreen("Выберите одно из действий (введите число):");
                Console.WriteLine("1 - играть");
                Console.WriteLine("2 - выход");
                Console.WriteLine("");

                string key = Console.ReadLine().Trim();

                if ((key == "1" || key == "2" || key == "3" || key == "4" || key == "5" || key == "6" || key == "7" || key == "8" || key == "9") && (Int32.TryParse(key, out rez)))
                {
                    correctInput = true;
                }
            }
            while (!correctInput);

            return rez;
        }
    }
}
