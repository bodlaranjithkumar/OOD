using System;

namespace ObjectOrientedDesign
{
    public class TicTacToe
    {
        private Player[,] board;
        private const int size = 3;
        private Player currentPlayer = Player._;
        private Player winner = Player._;
        private int moves;

        TicTacToe()
        {
            board = new Player[size, size];
            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    board[i, j] = Player._;
        }

        public void SetValue(int row, int col, Player player)
        {
            if (currentPlayer == player)
                throw new InvalidOperationException("It is not your move.");

            board[row, col] = player;
            currentPlayer = player;
            moves++;
        }

        public Player GetValue(int row, int col)
        {
            return board[row, col];
        }

        public bool CheckRows()
        {
            for (int i = 0; i < size; i++)
            {
                if (board[i, 0] != Player._
                    && board[i, 0] == board[i, 1]
                    && board[i, 1] == board[i, 2])
                {
                    winner = board[i, 0];
                    return true;
                }
            }

            return false;
        }

        public bool CheckColumns()
        {
            for (int j = 0; j < size; j++)
            {
                if (board[0, j] != Player._
                    && board[0, j] == board[1, j]
                    && board[1, j] == board[2, j])
                {
                    winner = board[0, j];
                    return true;
                }
            }

            return false;
        }

        public bool CheckDiagonals()
        {
            if (board[0, 0] != Player._
                && board[0, 0] == board[1, 1]
                && board[1, 1] == board[2, 2])
            {
                winner = board[0, 0];
                return true;
            }
            else if (board[0, 2] != Player._
                && board[0, 2] == board[1, 1]
                && board[1, 1] == board[2, 0])
            {
                winner = board[0, 2];
                return true;
            }

            return false;
        }

        public Player FindWinner()
        {
            if (moves != size * size)
                throw new Exception("Please finish all the moves.");
            else if (!MathDrawn())
                return winner;

            throw new Exception("The game is drawn.");
        }

        private bool MathDrawn()
        {
            return !(CheckRows() || CheckColumns() || CheckDiagonals());
        }

        public static void Main(string[] args)
        {
            //  O,X,O
            //  X,O,X
            //  O,X,X
            TicTacToe game1 = new TicTacToe();
            game1.SetValue(2, 2, Player.X);
            game1.SetValue(0, 0, Player.O);
            game1.SetValue(0, 1, Player.X);
            game1.SetValue(0, 2, Player.O);
            game1.SetValue(1, 0, Player.X);
            game1.SetValue(1, 1, Player.O);
            game1.SetValue(1, 2, Player.X);
            game1.SetValue(2, 0, Player.O);
            game1.SetValue(2, 1, Player.X);

            Console.WriteLine($"Winner of game1: {game1.FindWinner()}");
            Console.ReadKey();
        }
    }

    public enum Player { X, O, _ };
}
