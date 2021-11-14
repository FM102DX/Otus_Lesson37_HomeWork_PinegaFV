using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core.GameSettings;

namespace GuessNumberGame.Core.GameDevices
{
    public class SegaMegadDrive : Sega, INumbericGameDevice
    {
        public override string Name { get; set; } = "SegaMegadDrive";

        public override string AboutText { get; set; } = "This is Sega Megad Drive! :)";

        public override ConsoleColor MyColor { get; set; } = ConsoleColor.DarkGreen;

        public override  void Run(INumbericGame<INumbericGameSettings> game)
        {
            base.Run(game);
        }
    }
}
