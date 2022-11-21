var contacts = new List<string>();

contacts.Add("Sasha:sasha@gmail.com");
contacts.Add("Sancho:sancho@mail.ru");
contacts.Add("Roma:roma@gmail.com");
contacts.Add("Gusein:gusein@mail.com");
contacts.Add("G:gusein@mail.com");
contacts.Add(":");
contacts.Add("");
contacts.Add("Gusein:");
contacts.Add("Gu:gusein@mail.com");
contacts.Add("G:gusein@mail.com");
contacts.Add("Roma:4567@gmail.com");
contacts.Add("Sasha:sa@gm.com");
contacts.Add(":gusein@mail.com");
contacts.Add("Roma:");
contacts.Add($"{null}:sa@gm.com:priz@rty.com");
contacts.Add($"{null}:{null}");
contacts.Add($"Sasha:{null}");
contacts.Add(":gusein@mail.com");
contacts.Add("Roma:");

OptimizeContacts(contacts);

static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
{
    var dictionary = new Dictionary<string, List<string>>();
    string key = "";

    foreach(var contact in contacts)
    {
        string name = contact.Split(new char[] { ':' })[0];
        if (name.Length >= 2) key = name.Substring(0, 2);
        else if(name.Length == 1) key = name.Substring(0, 1);
        else key = ":";
        if(!dictionary.ContainsKey(key))
            dictionary[key] = new List<string>();
        dictionary[key].Add(contact);
    }
    return dictionary;
}