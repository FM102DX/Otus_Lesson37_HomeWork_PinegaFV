using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Abstract
{
    public interface ISupportColouredOutput
    {
        public ConsoleColor MyColor { get; set; }
       
    }
}
