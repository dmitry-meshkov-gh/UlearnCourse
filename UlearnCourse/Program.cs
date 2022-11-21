public class Program
{
    public static void Main()
    {
        Console.WriteLine(IsCorrect("(([])[])[]"));
        Console.WriteLine(IsCorrect("((][])"));
        Console.WriteLine(IsCorrect("((("));
        Console.WriteLine(IsCorrect("()"));
    }
    public static bool IsCorrect(string str)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>();
        dict['('] = ')';
        dict['['] = ']';

        foreach(var symbol in str)
        {
            if (dict.Keys.Contains(symbol))
                stack.Push(symbol);
            else if (dict.Values.Contains(symbol))
            {
                if (stack.Count == 0)
                    return false;
                var bracket = stack.Pop();
                if (dict[bracket] != symbol)
                    return false;
            }
            else
                return false;
        }
        return stack.Count == 0;
    }
    //public static bool IsCorrect(string str)
    //{
    //    var stack = new Stack<char>();
    //    foreach (var symbol in str)
    //    {
    //        switch (symbol)
    //        {
    //            case '(':
    //            case '[':
    //                stack.Push(symbol);
    //                break;
    //            case ')':
    //                if (stack.Count == 0) return false;
    //                if (stack.Pop() != '(') return false;
    //                break;
    //            case ']':
    //                if (stack.Count == 0) return false;
    //                if (stack.Pop() != '[') return false;
    //                break;
    //            default: return false;
    //        }
    //    }
    //    return stack.Count == 0;
    //}
}