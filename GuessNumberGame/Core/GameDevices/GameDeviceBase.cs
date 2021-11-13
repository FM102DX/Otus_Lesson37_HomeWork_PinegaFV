using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core.GameSettings;

namespace GuessNumberGame.Core.GameDevices
{
    public class GameDeviceBase : INumbericGameDevice
    {
        public virtual string Name { get; set; }

        public virtual void Run(INumbericGame<INumbericGameSettings> game)
        {

        }
    }
}
