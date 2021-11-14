using Autofac;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core;
using GuessNumberGame.Core.GameDevices;
using GuessNumberGame.Core.GameSettings;
using GuessNumberGame.Service;
using GuessNumberGames.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            AppMenuMaker menu = PrepareMenu();
            menu.Run();
        }

        public static AppMenuMaker PrepareMenu()
        {
            AppMenuMaker menu = new AppMenuMaker("Добро пожаловать в игровой зал!", "Приходите к нам еще ;)");

            menu.AddMenuItemDelegate(1, "Run dendy", () =>
            {
                INumbericGameDevice myGameDevice = new Dendy();

                INumbericGame<INumbericGameSettings> myGame = new NumbersGame<GameSettingsMajor>();

                myGameDevice.Run(myGame);
            });

            menu.AddMenuItemDelegate(2, "Run sega", () =>
            {
                INumbericGameDevice myGameDevice = new Sega();

                INumbericGame<INumbericGameSettings> myGame = new NumbersGame<GameSettingsMajor>();

                myGameDevice.Run(myGame);
            });

            menu.AddMenuItemDelegate(3, "Run sega mega drive", () =>
            {
                INumbericGameDevice myGameDevice = new SegaMegadDrive();

                INumbericGame<INumbericGameSettings> myGame = new NumbersGame<GameSettingsMajor>();

                myGameDevice.Run(myGame);
            });

            menu.AddMenuItemDelegate(4, "Run sega genesis", () =>
            {
                INumbericGameDevice myGameDevice = new SegaGenesis();

                INumbericGame<INumbericGameSettings> myGame = new NumbersGame<GameSettingsMajor>();

                myGameDevice.Run(myGame);
            });

            return menu;

        }

    }
}
