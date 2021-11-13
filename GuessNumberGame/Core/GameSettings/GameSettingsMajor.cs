using GuessNumberGame.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Core.GameSettings
{
    public  class GameSettingsMajor: INumbericGameSettings
    {
        public int NumberOfEfforts { get; set; } = 5;
        public int MinDigit { get; set; } = 0;
        public int MaxDigit { get; set; } = 200;

    }
}
