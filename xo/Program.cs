namespace TicTacToe
{
    using TicTacToeClassLibrary;

    /// <summary>
    /// Main class, containing Main() method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets an instance of Game object.
        /// </summary>
        public static Game Game { get; private set; }

        private static void Main()
        {
            while (true)
            {
                var boardSize = 3; // EnterBoardSize();
                var gameMode = Game.Mode.UserVsComputer;
                var userMark = ConsoleUI.ChooseMark();

                Game = new Game(new GameParams(boardSize, gameMode, userMark));

                if (ConsoleUI.Start(Game))
                {
                    return;
                }
            }
        }
    }
}
