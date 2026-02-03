using System.Diagnostics;

List<int> tempe = new List<int>();
int cptInvalide = 0;


Console.WriteLine("entrer des température");
Console.WriteLine("-999 pour sortir");

while (true)
{
   
    int temperature = int.Parse(Console.ReadLine());
    if ( temperature != -999) 
    {
        
        
        if (temperature <= 50 && temperature >= -50)
        {
            tempe.Add(temperature);

        }
        else
        {
            cptInvalide++;
        }
    }
    else 
    {
        break;
    }

}

tempe.Sort();
//valide
Console.WriteLine(tempe.Count);
//invalide
Console.WriteLine(cptInvalide);
//temperature max
Console.WriteLine(tempe[tempe.Count - 1]);
//temparature min
Console.WriteLine(tempe[0]);
