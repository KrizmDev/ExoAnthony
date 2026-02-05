using Exo_21.Expeption;

int[] tabl = new int[5];
tabl[0] = 10;
tabl[1] = 18;
tabl[2] = 5;
tabl[3] = 1;
tabl[4] = -2;

 static double calculMoyenn (int[] table)
{
    if (table == null || table.Length == 0)
        throw new ExceptionSaisieInvalide("Le tableau ne peux pas être vide");

    foreach(int i in table)
    {
        if (i < 0 || i > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(table));
        }
    }
    return table.Average();
}

try
{
   double moyenne = calculMoyenn(tabl);
    Console.WriteLine($"La moyenne est de {moyenne}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}