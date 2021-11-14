using GuessNumberGame;
using GuessNumberGame.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGames.Core
{
    public class NumbersGame<T> : INumbericGame<INumbericGameSettings>, ISupportColouredOutput where T: INumbericGameSettings,  new()
    {
        private int NumberOfEfforts { get; set; }
        private int MinDigit { get; set; }
        private int MaxDigit { get; set; }
        public virtual ConsoleColor MyColor { get; set; } = ConsoleColor.White;

        public void Start()
        {
            T t = new T();
            NumberOfEfforts = t.NumberOfEfforts;
            MinDigit = t.MinDigit;
            MaxDigit = t.MaxDigit;

            ConsoleWriter.WriteGreen("*** Вас приветствует игра 'Угадай число' ***");

            while (true)
            {
                ConsoleWriter.WriteGreen("Начинаем новую игру!");

                int targetNumber = ServiceFunctions.random.Next(MinDigit, MaxDigit);

                ConsoleWriter.WriteWithColor($"Система загадала число от {MinDigit} до {MaxDigit}. У вас {NumberOfEfforts} попыток", MyColor);

                int effortsLeft = NumberOfEfforts;

                bool hasEfforts;
                bool guessed;
                bool hasToBeMore;
                bool hasToBeLess;

                GameStepResultEnum gameRezult;

                while (true)
                {
                    int enteredNumber = 0;

                    Console.WriteLine($"введите число от 0 до 99 или '/' для выхода. У вас осталось {effortsLeft} попыток");

                    string s = Console.ReadLine().Trim();

                    if (s==@"/")
                    {
                        gameRezult = GameStepResultEnum.UserExits;
                        break;
                    }

                    bool validEntry = int.TryParse(s, out enteredNumber);

                    if (!validEntry)
                    {
                        ConsoleWriter.WriteRed($"Неверный ввод");
                        continue;
                    }

                    effortsLeft -= 1;
                    hasEfforts = effortsLeft > 0;
                    guessed = enteredNumber == targetNumber;
                    hasToBeMore = enteredNumber < targetNumber;
                    hasToBeLess = enteredNumber > targetNumber;

                    if (guessed) 
                    {
                        Console.WriteLine($"Поздравляем, вы выиграли!");
                        gameRezult = GameStepResultEnum.UserWins;
                        break;
                    }
                    else if (!hasEfforts)
                    {
                        ConsoleWriter.WriteYellow($"Вы проиграли. Число было {targetNumber}");
                        gameRezult = GameStepResultEnum.UserLose;
                        break;
                    }
                    else if(hasToBeMore && hasEfforts)
                    {
                        Console.WriteLine($"Число должно быть больше");
                    }
                    else if (hasToBeLess && hasEfforts)
                    {
                        Console.WriteLine($"Число должно быть меньше");
                    }
                }

                switch(gameRezult)
                {
                    case GameStepResultEnum.UserExits:
                        Console.WriteLine("Спасибо за игру!"); 
                        return;
                }

            }
        }

        private enum GameStepResultEnum
        {
            UserWins=1,
            UserExits=2,
            UserLose=3
        }
    }
}
