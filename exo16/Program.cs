List<string> listeDeString = new List<string>();


Console.WriteLine("Choisir un mot a ajouter");
Console.WriteLine("écrire stop pour arreter");




while (true)
{
    string? mot = Console.ReadLine();
    if (mot == "stop")
    {
        break;
    }
    else listeDeString.Add(mot);
}

Console.WriteLine(listeDeString.Count);
foreach (string str  in listeDeString)
{
    Console.Write(str);
}