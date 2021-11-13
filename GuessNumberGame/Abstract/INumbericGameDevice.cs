using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Abstract
{
    public interface INumbericGameDevice
    {
        public string Name { get; set; }
        public void Run(INumbericGame<INumbericGameSettings> game);
    }
}
