using System;
using System.Collections.Generic;

namespace cse210_01
{
    public class ticTacToe
    {
        // ATTRIBUTES
        int turnsLeft = 9;
        bool xTurn = true;
        string xO = "x";
        List<string> space = new List<string>()
        {
            "1","2","3","4","5","6","7","8","9"
        };
        List<string> board = new List<string>()
        {
            ".","|",".","|",".",
            "-","+","-","+","-",
            ".","|",".","|",".",
            "-","+","-","+","-",
            ".","|",".","|","."
        };

        // METHODS
        public void drawBoard()
        {
            int count = 0;
            while (count < space.Count)
            {
                for (int i = 0; i < board.Count; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.Write("\n");
                    }

                    if (board[i] == ".")
                    {
                        Console.Write(space[count]);
                        count++;
                    }
                    else
                    {
                        Console.Write(board[i]);
                    }
                }
            }
            Console.WriteLine("\n");


        }

        public void pickSpace(string xOxO)
        {
            Console.WriteLine($"It's {xOxO}'s turn.");
            Console.Write("Pick a space [1-9]: ");
            int chosenSpace = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (space[chosenSpace - 1] != "x" && space[chosenSpace - 1] != "o")
                {
                    space[chosenSpace - 1] = xOxO;
                    break;
                }
                else
                {
                    Console.Write("\nThat space is taken, choose again: ");
                    chosenSpace = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void switchTurn()
        {
            if (xTurn)
            {
                xO = "o";
                xTurn = false;
            }
            else
            {
                xO = "x";
                xTurn = true;
            }
        }

        public void playGame()
        {
            while (turnsLeft > 0)
            {
                drawBoard();
                pickSpace(xO);
                switchTurn();
                turnsLeft--;
            }

            drawBoard();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
        ticTacToe game = new ticTacToe();
        game.playGame();
        }
    }
}