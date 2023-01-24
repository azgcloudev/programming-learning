using System;

namespace ChallangeTicTacToe
{
    class Program
    {
        /// <summary>
        /// Prints in the console any board composed of 2D arrays
        /// </summary>
        /// <param name="array">2D array</param>
        static void PrintBoard(string[,] array)
        {
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

        static string AskName(int playerNumber)
        {
            string? name;

            if (playerNumber == 1)
            {
                Console.Write("Player 1 what is your name? ");
                name = Console.ReadLine();
            }
            else
            {
                Console.Write("Player 2 what is your name? ");
                name = Console.ReadLine();
            }

            return name;
        }


        /// <summary>
        /// Ask for a board number to the player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>Returns an int. If input cannot be parsed to int will return -1</returns>
        static int PlayerInput(string player)
        {
            Console.Write("{0} is your turn, choose your position number: ", player);
            string? inputNotParse = Console.ReadLine();
            if (int.TryParse(inputNotParse, out int input))
            {
                return input;
            }
            // return -1 in case the input cannot be parse to an int
            else
            {
                return -1;
            }

        }

        static bool ValidateIfUse(string[,] array, int position)
        {
            switch (position)
            {
                case 1:
                    if (array[1, 1] == "X" || array[1, 1] == "O")
                    {
                        return true;
                    }
                    return false;

                case 2:
                    if (array[1, 5] == "X" || array[1, 5] == "O")
                    {
                        return true;
                    }
                    return false;
                case 3:
                    if (array[1, 9] == "X" || array[1, 9] == "O")
                    {
                        return true;
                    }
                    return false;
                case 4:
                    if (array[4, 1] == "X" || array[4, 1] == "O")
                    {
                        return true;
                    }
                    return false;
                case 5:
                    if (array[4, 5] == "X" || array[4, 5] == "O")
                    {
                        return true;
                    }
                    return false;
                case 6:
                    if (array[4, 9] == "X" || array[4, 9] == "O")
                    {
                        return true;
                    }
                    return false;
                case 7:
                    if (array[7, 1] == "X" || array[7, 1] == "O")
                    {
                        return true;
                    }
                    return false;
                case 8:
                    if (array[7, 5] == "X" || array[7, 5] == "O")
                    {
                        return true;
                    }
                    return false;
                case 9:
                    if (array[7, 9] == "X" || array[7, 9] == "O")
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }



        static void ModifyBoard(string[,] board, int position, string symbol)
        {
            switch (position)
            {
                case 1:
                    board[1, 1] = symbol;
                    break;
                case 2:
                    board[1, 5] = symbol;
                    break;
                case 3:
                    board[1, 9] = symbol;
                    break;
                case 4:
                    board[4, 1] = symbol;
                    break;
                case 5:
                    board[4, 5] = symbol;
                    break;
                case 6:
                    board[4, 9] = symbol;
                    break;
                case 7:
                    board[7, 1] = symbol;
                    break;
                case 8:
                    board[7, 5] = symbol;
                    break;
                case 9:
                    board[7, 9] = symbol;
                    break;
                default:
                    break;
            }
        }


        static void Main(string[] args)
        {
            // ---- main scope variables ----
            // game board variable
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

            // validation to exit the game while playing
            bool isGameFinish = false;

            // players
            string? player1 = string.Empty;
            string? player2 = string.Empty;



            // TODO
            // input board position
            // check if position has been already selected
            // apply position
            // check if winner

            Console.Write("Welcome to Tic Tac Toe\n\nTo start the game press the SPACEBAR, or Q to exit> ");
            ConsoleKeyInfo initialOption = Console.ReadKey();


            // the game starts and prints the board
            if (initialOption.Key == ConsoleKey.Spacebar)
            {
                Console.Clear(); // clear terminal
                Console.WriteLine("Let's Go!\n");

                // Ask for the players name and save it
                player1 = AskName(1);
                player2 = AskName(2);

                Console.Clear();

                while (!isGameFinish)
                {
                    // loop for the maximum number of entries which is 9
                    for (int i = 0; i < 9; i++)
                    {
                        // tracks each user position
                        int position;

                        // shows current board
                        PrintBoard(TicTacBoard);

                        // to alternate players use even numbers for player 1 and odd for player 2
                        if (i % 2 == 0)
                        {
                            position = PlayerInput(player1);

                            while (ValidateIfUse(TicTacBoard, position))
                            {
                                Console.WriteLine("\nThis position was already selected, please choose again");
                                position = PlayerInput(player1);
                            }

                            ModifyBoard(TicTacBoard, position, "X");
                        }
                        else
                        {
                            position = PlayerInput(player2);

                            while (ValidateIfUse(TicTacBoard, position))
                            {
                                Console.WriteLine("\nThis position was already selected, please choose again");
                                position = PlayerInput(player2);
                            }

                            ModifyBoard(TicTacBoard, position, "O");
                        }
                        Console.Clear();
                    }
                    isGameFinish = true;
                }
            }
            // do not start the game, then exit the game and show message
            else
            {
                Console.Clear();
                Console.WriteLine("Bye!");
            }
        }
    }
}
