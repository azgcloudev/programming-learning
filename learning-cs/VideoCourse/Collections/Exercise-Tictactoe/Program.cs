string[,] board =
{
    {"x","x","o"},
    {"4","x","o"},
    {"7","8","o"},

};

Console.WriteLine(CheckWinner(board));

static bool CheckWinner(string[,] board)
{
    // check horizontal and vertical
    for (int i = 0; i < 3; i++)
    {
        // horizontal
        if (board[i,0] == board[i,1] && board[i,1] == board[i,2])
        {
            return true;
        }

        // vertical
        if (board[0,i] == board[1,i] && board[1,i] == board[2,i])
        {
            return true;
        }
    }

    // diagonals
    if (board[0,0] == board[1,1] && board[1,1] == board[2,2])
    {
        return true;
    }
    else if (board[0,2] == board[1,1] && board[1,1] == board[2,0])
    {
        return true;
    }

    // if no winner
    return false;
}