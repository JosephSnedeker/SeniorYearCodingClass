using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jsnedeker_tictactoe
{
    class Program
    {
        static string[,] board = new string[3, 3];
        static string quit = "";
        static void Main(string[] args)
            
        {
            bool runp1 = true;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = " ";
                }
                
            }
            
            do
            {
                runp1 = true;
                while (runp1)
                {
                    
                    Console.WriteLine("player x choose an i coordinant");
                    int xcoor = int.Parse(Console.ReadLine());
                    Console.WriteLine("player x choose an j coordinant");
                    int ycoor = int.Parse(Console.ReadLine());



                    if (board[xcoor, ycoor] != "O" && board[xcoor, ycoor] != "X")
                    {
                        board[xcoor, ycoor] = "X";
                        runp1 = false;
                    }
                    else if (board[xcoor, ycoor] == "O" || board[xcoor, ycoor] == "X")
                    {
                        runp1 = true;
                        Console.WriteLine("enter a valid position");
                    }
                    isWin();
                }

                

                Print(board);

                bool runp2 = true;
                while (runp2)
                {
                    Console.WriteLine("player O choose an i coordinant");
                    int xcoor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("player O choose an j coordinant");
                    int ycoor2 = int.Parse(Console.ReadLine());

                    if (board[xcoor2, ycoor2] != "O" && board[xcoor2, ycoor2] != "X")
                    {
                        board[xcoor2, ycoor2] = "O";
                        runp2 = false;
                    }
                    else if (board[xcoor2, ycoor2] == "O" || board[xcoor2, ycoor2] == "X")
                    {
                        runp2 = true;
                        Console.WriteLine("enter a valid position");
                    }


                    isWin();
                }
                


                Print(board);
                
            } while (quit != "quit");
      
        }
        static void Print(string[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("|" + board[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
        static void isWin()
        {
            bool isgame = false;
            if (board[0,0] == board[0,1] && board[0,1] == board[0,2] && board[0,2] != " "||
                board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != " " ||
                board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != " " ||
                board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != " " ||
                board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != " " ||
                board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != " " ||
                board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != " " ||
                board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != " ")
            {
                Console.WriteLine("THERE IS A WINNER");

            }
            else
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == " ")
                           isgame = true;                        
                    }

                    
                }
                if (!isgame)
                {
                    Console.WriteLine("THERE IS A TIE");
                    Console.ReadKey();
                    quit = "quit";
                }
            }
            
        }
        
        
    }
}
