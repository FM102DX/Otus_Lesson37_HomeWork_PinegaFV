using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core.GameSettings;

namespace GuessNumberGame.Core.GameDevices
{
    public class SegaGenesis : Sega, INumbericGameDevice
    {
        public override string Name { get; set; } = "Sega Genesis";
        public override string AboutText { get; set; } = "This is Sega Genesis! :)";

        public override ConsoleColor MyColor { get; set; } = ConsoleColor.Yellow;

        public override  void Run(INumbericGame<INumbericGameSettings> game)
        {
            base.Run(game);
        }

    }
}
