using ExoSurPoo.Class;
using ExoSurPoo.Class.CompteBancaire;
using ExoSurPoo.Class.Forme;
using ExoSurPoo.Class.NewFolder1;
using ExoSurPoo.Class.Travailleur;
/*

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Chien chien1 = new Chien("loulou", 5, "pinscher");
        Chien chien = new Chien("odin", 5, "cane corso");

                chien1.Nom = "popo";
            Chien.NomDuChenil = "chenil";
                Console.WriteLine($"{chien1} \n {chien}");
        }
    }
}


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            Salarie num1 = new Salarie("Chloé","compta",3500);
            Salarie num2 = new Salarie("Pierre", "compta", 4500);
            Salarie num3 = new Salarie("Jeans", "compta", 550);

            Console.WriteLine($"{num1} \n {num2} \n {num3}");
            num1.AfficherSalire();
        }
    }
}


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Paramètre de partie ===");
            int nbEssaie = 10;
            Console.WriteLine("voulez-vous un nombre d'essaie spécifique (10 par defaut ? O/N");
            string reponse = Console.ReadLine().Trim().ToUpper();

            if(reponse == "O")
            {
                Console.WriteLine("choisir votre nombre d'essaie");
                nbEssaie = int.Parse(Console.ReadLine());
            }
            string mot = Pendu.GenerateurMot.ObtenirMot();
            Pendu partie = new Pendu(mot , nbEssaie);

            Console.WriteLine($"le mots à trouver : {partie.Masque}");
            Console.WriteLine($"il vous reste : {nbEssaie} essaie restant");

            while (nbEssaie > 0 && !partie.TestWin())
            {
                Console.Write("choisir une lettre:");
                string imput =Console.ReadLine().ToUpper();

                char lettres = imput[0];
                bool trouve = partie.TestChar(lettres);
                if (trouve)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("bien joué vous avez trouvé");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essayer a nouveau");
                    Console.ForegroundColor = ConsoleColor.White;
                    nbEssaie--;

                }
               
                Console.WriteLine($"le mots à trouver : {partie.Masque}");
                Console.WriteLine($"il vous reste : {nbEssaie} essaie restant");

            }

            if (partie.TestWin())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("vous avez gagné!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Vous avez perdu le mot était {mot}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
*
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== création de votre compte bancaire ===");
            Console.WriteLine("Entrer votre nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Combien deposer vous sur votre compte courant?");
            float soldeC = int.Parse(Console.ReadLine());
            Console.WriteLine("qu'elle est la devise?");
            string devise = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("combien aller vous mettre dans votre compte epargne?");
            float soldeE = int.Parse(Console.ReadLine());

            CompteCourant compteCourant = new CompteCourant(nom, soldeC, devise);
            CompteEpargne compteEpargne = new CompteEpargne(nom, soldeE, devise);

            bool sortie = false;

            while(true)
            {
                Console.WriteLine("===Bienvenue sur votre compte bancaire===");
                Console.WriteLine();
                Console.WriteLine("1---Afficher votre solde");
                Console.WriteLine("2---Acceder a votre compte Courant");
                Console.WriteLine("3---Acceder a votre Epargne");
                Console.WriteLine("0---Sortir");
                Console.WriteLine();
                Console.Write("faites votre choix:");
                int choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Votre soldle total est de {compteCourant.Solde + compteEpargne.Solde}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===Bienvenue sur votre compte Courant===");
                        Console.WriteLine();
                        Console.WriteLine("1---deposer");
                        Console.WriteLine("2---retirer");
                        Console.WriteLine("0---Sortir");
                        Console.WriteLine();
                        Console.Write("faites votre choix:");
                        int choix2 = int.Parse(Console.ReadLine());
                        switch (choix2)
                        {
                            case 0:
                                Console.Clear();
                                break;
                            case 1:
                                Console.Clear();
                                Console.Write("Combien voulez vous déposer?");
                                float montant = float.Parse(Console.ReadLine());
                                compteCourant.deposer(montant);
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Combien voulez vous retirer?");
                                float montant2 = float.Parse(Console.ReadLine());
                                compteCourant.retirerAvecDecouvert(montant2);
                                break;
                        }break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("===Bienvenue sur votre compte Courant===");
                        Console.WriteLine();
                        Console.WriteLine("1---calcule interet");
                        Console.WriteLine("0---sortir");
                        Console.Write("faites votre choix:");
                        int choix3 = int.Parse(Console.ReadLine());
                        switch (choix3)
                        {
                            case 0:
                                Console.Clear();
                                break;
                            case 1:
                                Console.Clear();
                                compteEpargne.Interet();
                                break;
                        }break;



                }

            }
        }
    }
}


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List <Travailleur> travailleursL = new List<Travailleur> ();

           
            while (true) {

                Console.WriteLine("=== Travailleur ou Scientifque");
                Console.WriteLine();
                Console.WriteLine("1===Ajouter un Travailleur");
                Console.WriteLine("2=== Ajouter un scitifique");
                Console.WriteLine("3=== Affiche les employé");
                Console.WriteLine("0=== Quitter");
                Console.Write("Faites votre choix: ");
                int choix = int.Parse(Console.ReadLine());
                switch (choix)
                 {
                    case 0:
                        Environment.Exit (0);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Quelle est son nom?");
                    string? nom = Console.ReadLine();
                    Console.WriteLine("Quelle est son prenom?");
                    string? prenom = Console.ReadLine();
                    Console.WriteLine("Quelle est son mail?");
                    string mail = Console.ReadLine();
                    Console.WriteLine("Quelle est son numéro?");
                    string tel = Console.ReadLine();
                    Console.WriteLine("Quelle est son Entrepise?");
                    string nomentreprise = Console.ReadLine();
                    Console.WriteLine("Quelle est son adresse de L'entrerpise?");
                    string adresseentreprise = Console.ReadLine();
                    Console.WriteLine("Quelle est son Numéro pro?");
                    string numpro = Console.ReadLine();
                    Travailleur travailleur1 = new Travailleur( nomentreprise, adresseentreprise, numpro,nom, prenom,mail,tel);
                    Console.WriteLine(travailleur1);
                        travailleursL.Add(travailleur1);
                    break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Quelle est son nom?");
                        string? nom1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son prenom?");
                        string? prenom1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son mail?");
                        string mail1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son numéro?");
                        string tel1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son Entrepise?");
                        string nomentreprise1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son adresse de L'entrerpise?");
                        string adresseentreprise1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son Numéro pro?");
                        string numpro1 = Console.ReadLine();
                        Console.WriteLine("Quelle est sa discpline?");
                        string discp1 = Console.ReadLine();
                        Console.WriteLine("Quelle est son type?");
                        string type1 = Console.ReadLine();
                    Scientifique scientifique1 = new Scientifique(discp1 , type1 , nomentreprise1, adresseentreprise1, numpro1, nom1, prenom1, mail1, tel1);
                        Console.WriteLine(scientifique1);
                        travailleursL.Add(scientifique1);
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < (travailleursL.Count); i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine(travailleursL[i]);

                        }
                        break;
                }
            }

        }
    }
}

{
    WaterTank citerne1 = new WaterTank(500, 1000);
    WaterTank citerne2 = new WaterTank(300, 800);

    Console.WriteLine($"Volume total des citernes : {WaterTank.VolumeTotalCiternes} L\n");

    Console.WriteLine("Remplissage de la citerne 1 (1200 L)");
    double excedent = citerne1.Remplir(1200);
    Console.WriteLine($"Excédent : {excedent} L");
    Console.WriteLine($"Niveau : {citerne1.NiveauRemplissage} L");
    Console.WriteLine($"Poids total : {citerne1.PoidsTotal()} kg\n");

    Console.WriteLine("Vidage de la citerne 1 (500 L)");
    double vide = citerne1.Vider(500);
    Console.WriteLine($"Eau vidée : {vide} L");
    Console.WriteLine($"Niveau : {citerne1.NiveauRemplissage} L\n");

    Console.WriteLine("Vidage de la citerne 1 (800 L)");
    vide = citerne1.Vider(800);
    Console.WriteLine($"Eau vidée : {vide} L");
    Console.WriteLine($"Niveau : {citerne1.NiveauRemplissage} L");

    Console.ReadLine();
}*/


Voiture voiture = new Voiture("Swift", "susuki");
voiture.Demarrer();

VoitureHybirde voitureHybirde = new VoitureHybirde("toyota", "yaris");
voitureHybirde.Demarrer();
voitureHybirde.Recharger();

Hydravion hydravion = new Hydravion("avion", "eau");
hydravion.Atterrir();
hydravion.Demarrer();
hydravion.Decoller();
hydravion.Naviguer();