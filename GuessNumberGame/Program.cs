using GuessNumberGame.Abstract;
using GuessNumberGame.Core;
using GuessNumberGame.Core.GameDevices;
using GuessNumberGame.Core.GameSettings;
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

            INumbericGameDevice myGameDevice = new Sega();

            INumbericGame<INumbericGameSettings> myGame = new NumbersGame<GameSettingsMajor>();

            myGameDevice.Run(myGame);


        }




    }
}
