using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core.GameSettings;

namespace GuessNumberGame.Core.GameDevices
{
    public class GameDeviceBase : INumbericGameDevice, ISupportColouredOutput
    {
        public virtual string Name { get; set; }

        public virtual ConsoleColor MyColor { get; set; }

        public virtual string AboutText { get; set; }


        internal INumbericGame<INumbericGameSettings> CurrentGame;

        public virtual void Run(INumbericGame<INumbericGameSettings> game)
        {
            CurrentGame = game;
        }

        internal void ShowAboutText()
        {
            Console.WriteLine(AboutText);
        }
    }
}
