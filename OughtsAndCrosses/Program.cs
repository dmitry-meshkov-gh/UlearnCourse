class Program
{
    public enum Mark
    {
        Empty,
        Cross,
        Circle
    }

    public enum GameResult  
    {
        CrossWin,
        CircleWin,
        Draw
    }

    public static void Main()
    {
        Run("XXX OO. ...");
        Run("OXO XO. .XO");
        Run("OXO XOX OX.");
        Run("XOX OXO OXO");
        Run("... ... ...");
        Run("XXX OOO ...");
        Run("XOO XOO XX.");
        Run(".O. XO. XOX");
    }

    private static void Run(string description)
    {
        Console.WriteLine(description.Replace(" ", Environment.NewLine));
        Console.WriteLine(GetGameResult(CreateFromString(description)));
        Console.WriteLine();
    }

    private static GameResult GetGameResult(Mark[,] marks)
    {
        bool crossWin = (HasWinSequence(marks, Mark.Cross));
        bool circleWin = (HasWinSequence(marks, Mark.Circle));
        return crossWin == circleWin ? GameResult.Draw : !crossWin ? GameResult.CircleWin : GameResult.CrossWin;
    }

    private static bool HasWinSequence(Mark[,] marks, Mark mark)
    {
        for(int i = 0; i < marks.GetLength(0); i++)
        {
            if (marks[i, 0] == mark && marks[i, 1] == mark && marks[i, 2] == mark)
                return true;
            if (marks[0, i] == mark && marks[1, i] == mark && marks[2, i] == mark)
                return true;
        }

        if (marks[0, 0] == mark && marks[1, 1] == mark && marks[2, 2] == mark)
            return true;
        if (marks[2, 0] == mark && marks[1, 1] == mark && marks[0, 2] == mark)
            return true;

        return false;
    }

    private static Mark[,] CreateFromString(string str)
    {
        var field = str.Split(' ');
        var ans = new Mark[3, 3];
        for (int x = 0; x < field.Length; x++)
            for (var y = 0; y < field.Length; y++)
                ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
        return ans;
    }
}