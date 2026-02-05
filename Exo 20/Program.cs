//cas 1

SortedSet<string>pseudo = new SortedSet<string>();

pseudo.Add("totokiller");
pseudo.Add("FrancisLasaucissedu78");
pseudo.Add("Frenchyzz");
pseudo.Add("popolee2");
pseudo.Add("popolee3.5");
pseudo.Add("FrancisLasaucissedu78");

foreach  (string s in pseudo)
{
    Console.WriteLine(s);
    if(s == "popolee2")
    {
        Console.WriteLine("Pseudo précis trouvé: popolee2");
    }
}

Queue<string> client = new Queue<string>();

client.Enqueue("francois");
client.Enqueue("jf");
client.Enqueue("clem");


while (client.Count > 0)
{
    Console.ReadLine();
    string ClientEnCours = client.Dequeue();
    Console.WriteLine(ClientEnCours);
    Console.WriteLine(client.Count);
}
Console.WriteLine("c'est l'heure de la pause");


Dictionary<string,int> eleve =  new Dictionary<string,int>();

eleve["loulou"] = 17;
eleve["pierre"] = 3;
eleve["frac"] = 4;
eleve["ju"] = 12;
eleve["lala"] = 10;

var modifEleve = eleve.ElementAt(2);
eleve[modifEleve.Key] = 18;
Console.WriteLine(eleve.Last());
foreach(var s in eleve)
{
    Console.WriteLine($"{s.Key} = {s.Value}");
}



