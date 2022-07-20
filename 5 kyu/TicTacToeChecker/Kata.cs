namespace TicTacToeChecker
{
	public class Kata
	{
		public static int IsSolved(int[,] board)
		{
			bool hasZero = HasZero(board);

			if(HasWinner(board, out int winnerId))
				return winnerId;

			if (hasZero)
				return -1; 

			return 0;
		}

		private static bool HasZero(int[,] board)
		{
			foreach(var item in board)			
				if (item == 0)
					return true;

			return false;
		}

		private static bool HasWinner(int[,] board, out int winnerId)
		{
			if (HasWinnerHorizontal(board, out winnerId))
				return true;

			if (HasWinnerVertical(board, out winnerId))
				return true;

			if (HasWinnerDiagonals(board, out winnerId))
				return true;

			return false;
		}

		private static bool HasWinnerHorizontal(int[,] board, out int winnerId)
		{
			int amountOfConsectuve = 0;
			int crossOrToe = 0;

			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if (board[i, j] == crossOrToe && board[i, j] != 0)
					{
						amountOfConsectuve++;

						if (amountOfConsectuve == 3)
						{
							winnerId = crossOrToe;
							return true;
						}
					}
					else if (board[i, j] == 0)
					{
						crossOrToe = 0;
						amountOfConsectuve = 0;
					}
					else
					{
						amountOfConsectuve = 1;
						crossOrToe = board[i, j];
					}
				}

				amountOfConsectuve = 0;
				crossOrToe = 0;
			}

			winnerId = 0;
			return false;
		}

		private static bool HasWinnerVertical(int[,] board, out int winnerId)
		{
			int amountOfConsectuve = 0;
			int crossOrToe = 0;

			for (int j = 0; j < board.GetLength(1); j++)
			{
				for (int i = 0; i < board.GetLength(0); i++)
				{
					if (board[i, j] == crossOrToe && board[i, j] != 0)
					{
						amountOfConsectuve++;

						if (amountOfConsectuve == 3)
						{
							winnerId = crossOrToe;
							return true;
						}
					}
					else if (board[i, j] == 0)
					{
						crossOrToe = 0;
						amountOfConsectuve = 0;
					}
					else
					{
						amountOfConsectuve = 1;
						crossOrToe = board[i, j];
					}
				}

				amountOfConsectuve = 0;
				crossOrToe = 0;
			}

			winnerId = 0;
			return false;
		}

		private static bool HasWinnerDiagonals(int[,] board, out int winnerId)
		{
			int amountOfConsectuve = 0;
			int crossOrToe = 0;

			for (int i = 0; i < board.GetLength(0); i++)
			{
				if (board[i, i] == crossOrToe && board[i, i] != 0)
				{
					amountOfConsectuve++;

					if (amountOfConsectuve == 3)
					{
						winnerId = crossOrToe;
						return true;
					}
				}
				else if (board[i, i] == 0)
				{
					crossOrToe = 0;
					amountOfConsectuve = 0;
				}
				else
				{
					amountOfConsectuve = 1;
					crossOrToe = board[i, i];
				}
			}

			for (int i = 0, j = board.GetLength(0) - 1; i < board.GetLength(0); i++, j--)
			{
				if (board[i, j] == crossOrToe && board[i, j] != 0)
				{
					amountOfConsectuve++;

					if (amountOfConsectuve == 3)
					{
						winnerId = crossOrToe;
						return true;
					}
				}
				else if (board[i, j] == 0)
				{
					crossOrToe = 0;
					amountOfConsectuve = 0;
				}
				else
				{
					amountOfConsectuve = 1;
					crossOrToe = board[i, j];
				}
			}

			winnerId = 0;
			return false;
		}
	}
}