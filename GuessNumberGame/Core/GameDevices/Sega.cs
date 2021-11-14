using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Abstract;
using GuessNumberGame.Core.GameSettings;
using GuessNumberGame.Service;

namespace GuessNumberGame.Core.GameDevices
{
    public class Sega : GameDeviceBase, INumbericGameDevice
    {
        public override string Name { get; set; } = "Sega";

        public override string AboutText { get; set; } = "This is Sega! :)";

        public override ConsoleColor MyColor { get; set; } = ConsoleColor.Magenta;

        public override void Run(INumbericGame<INumbericGameSettings> game)
        {
            base.Run(game);
            ConsoleWriter.WriteYellow("");
            ConsoleWriter.WriteWithColor($"***** Привет, с вами игровая консоль {Name}! *****", MyColor);
            AppMenuMaker menu = PrepareMenu();
            menu.Run();
        }

        internal virtual AppMenuMaker PrepareMenu()
        {
            AppMenuMaker menu = new AppMenuMaker("", "");

            menu.AddMenuItemDelegate(1, "Играть", () =>
            {
                CurrentGame.Start();
            });

            menu.AddMenuItemDelegate(2, "Help&about", () =>
            {
                this.ShowAboutText();
            });



            return menu;

        }

    }
}
