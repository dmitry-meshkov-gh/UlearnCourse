Console.WriteLine(Compute("342*15-2/+"));

static int Compute(string str)
{
    var stack = new Stack<int>();
    var operations = new Dictionary<char, Func<int, int, int>>();
    operations.Add('+', (x, y) => x + y);
    operations.Add('-', (x, y) => x - y);
    operations.Add('*', (x, y) => x * y);
    operations.Add('/', (x, y) => x / y);

    foreach(var symbol in str)
    {
        if(symbol <= '9' && symbol >= '0')
        {
            stack.Push(symbol - '0');
        }
        else if(operations.ContainsKey(symbol))
        {
            stack.Push(operations[symbol] (stack.Pop(), stack.Pop()));
        }
        else
            throw new ArgumentException();
    }
    return stack.Pop();
}