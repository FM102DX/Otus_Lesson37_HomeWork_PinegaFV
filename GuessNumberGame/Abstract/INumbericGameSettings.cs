using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Abstract
{
    public interface INumbericGameSettings
    {
        public int NumberOfEfforts { get; set; }
        public int MinDigit { get; set; }
        public int MaxDigit { get; set; }
    }
}
