using exo15.Class;
using exo15.Interface;


class Program
{
    static void Main()
    {
        Arme creationArme()
        {
            Console.WriteLine("création de l'arme :");
            Console.Write("chosir un nom :");
            string nomArme = Console.ReadLine();
            Console.Write("combien de dégat? :");
            int degatArme = int.Parse(Console.ReadLine());
            Console.Write("combien de durabilité ? :");
            int durabilitéArme = int.Parse(Console.ReadLine());
            Arme arme = new Arme(nomArme, degatArme, durabilitéArme);
            return arme;
        }
        Personnage creationPersonnage(int choix)
        {
            Arme arme = creationArme();
            Console.WriteLine("création du personnage");
            Console.Write("chosir un nom :");
            string nom = Console.ReadLine();
            Console.Write("chosir un prenom :");
            string prenom = Console.ReadLine();
            Console.Write("combien de pv :");
            int pv = int.Parse(Console.ReadLine());
            Console.Write("combien de dégat :");
            int degat = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Mage mage = new Mage(nom, prenom, pv, degat, arme);
                    return mage;
                case 2:
                    Guerrier guerrier = new Guerrier(nom, prenom, pv, degat, arme);
                    return guerrier;
                case 3:
                    GuerrierMage guerrierMage = new GuerrierMage(nom, prenom, pv, degat, arme);
                    return guerrierMage;
                default:
                    Console.WriteLine("Personnage impossible");
                    return null;
            }
        }
        List<Personnage> personnages = new List<Personnage> { };
        Console.Write("Choisir le nombre de joueur : ");
        int nbJoueur = int.Parse(Console.ReadLine());

        for (int i = 0; i < nbJoueur; i++)
        {
            Console.WriteLine("=== Choisir un classe ===");
            Console.WriteLine("1===Mage");
            Console.WriteLine("2===Guerrier");
            Console.WriteLine("3===Guerrier Mage");
            Console.Write("Faites votre choix:");
            int choixClasse = int.Parse(Console.ReadLine());

            switch (choixClasse)
            {
                case 1:
                    Personnage mage = creationPersonnage(choixClasse);
                    personnages.Add(mage);
                    break;
                case 2:
                    Personnage guerrier = creationPersonnage(choixClasse);
                    personnages.Add(guerrier);
                    break;
                case 3:
                    Personnage guerrierMage = creationPersonnage(choixClasse);
                    personnages.Add(guerrierMage);
                    break;
            }

        }






        Console.WriteLine("=== Jeu de combat tour par tour ===\n");

        bool jeuEnCours = true;

        while (jeuEnCours)
        {
            foreach (Personnage p in personnages)
            {
                if (p._pv <= 0) continue;

                Console.WriteLine($"\nC'est le tour de {p._prenom} ({p._pv} PV)");


                Console.WriteLine("Choisissez une cible :");
                for (int i = 0; i < personnages.Count; i++)
                {
                    if (personnages[i] != p && personnages[i]._pv > 0)
                        Console.WriteLine($"{i}: {personnages[i]._prenom} ({personnages[i]._pv} PV)");
                }

                int cibleIndex;
                while (!int.TryParse(Console.ReadLine(), out cibleIndex) ||
                       cibleIndex < 0 || cibleIndex >= personnages.Count ||
                       personnages[cibleIndex] == p || personnages[cibleIndex]._pv <= 0)
                {
                    Console.WriteLine("Cible invalide, choisissez à nouveau :");
                }

                Personnage cible = personnages[cibleIndex];


                Console.WriteLine("Choisissez une action :");
                Console.WriteLine("1: Attaque normale");

                if (p is IAttaqueSpeciale)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2: Attaque spéciale");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (p is IMagie)
                {


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("3: Lancer sort");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                int action;
                while (!int.TryParse(Console.ReadLine(), out action) || action < 1 || action > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Action invalide, choisissez à nouveau :");
                    Console.ForegroundColor = ConsoleColor.White;
                }


                switch (action)
                {
                    case 1:
                        p.Attaquer(cible);
                        break;
                    case 2:
                        if (p is IAttaqueSpeciale attaquantSpecial)
                            attaquantSpecial.AttaqueSpeciale(cible);
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Action impossible !");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 3:
                        if (p is IMagie mage)
                            mage.LancerSort(cible);
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Action impossible !");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;
                }




                int vivants = 0;
                foreach (Personnage pers in personnages)
                    if (pers._pv > 0) vivants++;

                if (vivants <= 1)
                {
                    jeuEnCours = false;
                    break;
                }
            }
        }

        Console.WriteLine("\n=== Fin du jeu ===");
        foreach (var pers in personnages)
        {
            if (pers._pv > 0)
                Console.WriteLine($"{pers._prenom} est le gagnant avec {pers._pv} PV !");
        }
    }
}

