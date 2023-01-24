using System;

namespace ChallangeTicTacToe
{
    class Program
    {
        static bool CheckWinner(int[] array)
        {
            return false;
        }

        static string[,] Board()
        {
            string[,] TicTacBoard = new string[9, 11]
            {
                {" "," "," ","|"," "," "," ","|"," "," "," "},
                {" ","1"," ","|"," ","2"," ","|"," ","3"," "},
                {"_","_","_","|","_","_","_","|","_","_","_"},
                {" "," "," ","|"," "," "," ","|"," "," "," "},
                {" ","4"," ","|"," ","5"," ","|"," ","6"," "},
                {"_","_","_","|","_","_","_","|","_","_","_"},
                {" "," "," ","|"," "," "," ","|"," "," "," "},
                {" ","7"," ","|"," ","8"," ","|"," ","9"," "},
                {" "," "," ","|"," "," "," ","|"," "," "," "}
            };

            return TicTacBoard;
        }

        static void PrintBoard(string[,] array)
        {
            Console.Write("\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j >= 10)
                    {
                        Console.Write("{0}\n", array[i, j]);
                    }
                    else
                    {
                        Console.Write(array[i, j]);
                    }
                }
            }
            Console.Write("\n");
        }

        static int InputPosition(string player, string[,] board)
        {
            Console.Write("{0}: Choose your field: ", player);
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        static string[,] ModifyBoard(int position, string player, string[,] array)
        {
            string[,] newArray = array;

            if (player == "Player 1")
            {
                switch (position)
                {
                    case 1:
                        newArray[1, 1] = "X";
                        break;
                    case 2:
                        newArray[1, 5] = "X";
                        break;
                    case 3:
                        newArray[1, 9] = "X";
                        break;
                    case 4:
                        newArray[4, 1] = "X";
                        break;
                    case 5:
                        newArray[4, 5] = "X";
                        break;
                    case 6:
                        newArray[4, 9] = "X";
                        break;
                    case 7:
                        newArray[7, 1] = "X";
                        break;
                    case 8:
                        newArray[7, 5] = "X";
                        break;
                    case 9:
                        newArray[7, 9] = "X";
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
            else
            {
                switch (position)
                {
                    case 1:
                        newArray[1, 1] = "O";
                        break;
                    case 2:
                        newArray[1, 5] = "O";
                        break;
                    case 3:
                        newArray[1, 9] = "O";
                        break;
                    case 4:
                        newArray[4, 1] = "O";
                        break;
                    case 5:
                        newArray[4, 5] = "O";
                        break;
                    case 6:
                        newArray[4, 9] = "O";
                        break;
                    case 7:
                        newArray[7, 1] = "O";
                        break;
                    case 8:
                        newArray[7, 5] = "O";
                        break;
                    case 9:
                        newArray[7, 9] = "O";
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
            return newArray;
        }

        static bool Winner(string[,] array, string player)
        {
            string symbol;

            if (player == "Player 1")
            {
                symbol = "X";
            }
            else
            {
                symbol = "O";
            }

            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[1, 1] == symbol && array[1, 5] == symbol && array[1, 9] == symbol)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static void StartGame(string[,] board)
        {
            string player1 = "Player 1";
            string player2 = "Player 2";
            int input;

            Console.Write("Welcome to azgcloudev Tic Tac Toe Game!");

            // game has only a maximum o 9 tries
            for (int i = 0; i < 9; i++)
            {
                PrintBoard(board);

                if (i % 2 == 0)
                {
                    input = InputPosition(player1);
                    board = ModifyBoard(input, player1, board);
                    if (Winner(board, player1))
                    {
                        Console.Clear();
                        Console.WriteLine("{0} won the game!", player1);
                        break;
                    }
                    Console.Clear();
                }
                else
                {
                    input = InputPosition(player2);
                    board = ModifyBoard(input, player2, board);
                    Console.Clear();
                }

            }
        }

        static void Main(string[] args)
        {
            // game 
            StartGame(Board());

            Console.ReadKey();

        }
    }
}
