using System;
using System.Collections.Generic;

namespace cse210_01
{
    public class ticTacToe
    {
        // ATTRIBUTES
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

        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
        ticTacToe game = new ticTacToe();
        game.drawBoard();
        }
    }
}