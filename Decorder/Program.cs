using System.Text;

string text = "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой\r\nСдавайся НЕ твоего ума Ты не споСОбЕн Но может быть\r\nесли особенно упорно подойдешь к делу\r\n\r\nбудет Трудно конечнО\r\nКод ведЬ не из простых\r\nочень ХОРОШИЙ код\r\nто у тебя все получится\r\nи я буДу Писать тЕбЕ еще\r\n\r\nчао";
string[] words = text.Split(new char[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

string anotherText = "push Привет! Это снова я! Пока!\r\npop 5\r\npush Как твои успехи? Плохо?\r\npush qwertyuiop\r\npush 1234567890\r\npop 26";
string[] commands = anotherText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

// Console.WriteLine(DecodeMessage(words));
Console.WriteLine(ApplyCommands(commands));

string ApplyCommands(string[] commands)
{
        StringBuilder stringBuilder = new StringBuilder();
        foreach(string command in commands)
        {
            if (command.StartsWith("push"))
                stringBuilder.Append(command.Substring(5));
            if (command.StartsWith("pop"))
                stringBuilder.Length -= int.Parse(command.Replace("pop ", ""));
        }
        return stringBuilder.ToString();
}

static string DecodeMessage(string[] lines)
{
    List<string> message = new List<string>();
    foreach(string item in lines)
    {
        if (char.IsUpper(item[0]))
        {
            message.Add(item);
        }
    }
    message.Reverse();
    return String.Join(" ", message.ToArray());
}
