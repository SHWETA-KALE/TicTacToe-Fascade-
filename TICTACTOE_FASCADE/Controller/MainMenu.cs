using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TICTACTOE_FASCADE.Exceptions;
using TICTACTOE_FASCADE.Models;

namespace TICTACTOE_FASCADE.Controller
{
    internal class MainMenu
    {
        public static void Display(Player player1, Player player2)
        {
            
            Console.WriteLine("..............................................");
            Console.WriteLine("WELCOME TO TIC TAC TOE");
            Console.WriteLine($"Player 1: {player1.Name} X\n");
            Console.WriteLine($"Player 2: {player2.Name} O\n");
            Console.WriteLine("..............................................");

        }

        public static int GetPlayerChoice()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Enter Position(0-8): ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 0 && choice < 9)
                    {
                        return choice;
                    }
                    else
                    {
                        throw new InvalidInputException("Invalid input. Please enter a number between 0 and 8.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
