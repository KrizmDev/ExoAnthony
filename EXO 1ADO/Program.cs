using System.Text.RegularExpressions;
using EXO_1ADO.Class;
using EXO_1ADO.Repository;

EtudiantRepository eRepo = new EtudiantRepository();

eRepo.CreateTableEtudiant();


string logo = @"
       _             _ _             _       
   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ 
  / _ \ __| | | |/ _` | |/ _` | '_ \| __/ __|
 |  __/ |_| |_| | (_| | | (_| | | | | |_\__ \
  \___|\__|\__,_|\__,_|_|\__,_|_| |_|\__|___/
";
while (true)
{
    Console.WriteLine(logo);
    Console.WriteLine("1---Voir Tous les étudiants");
    Console.WriteLine("2---Ajouter un étudiant");
    Console.WriteLine("3---Modifier un étudiant");
    Console.WriteLine("4---Supprimer un étudiant");
    Console.WriteLine("5---Rechercher un étudiant par son nom ou prenom");
    Console.WriteLine("0---Quitter");

    int choix = 0;
    bool sasieValide = false;
    while (!sasieValide)
    {
        Console.Write("faite votre Choix : ");
        string saisie = Console.ReadLine();
        if (int.TryParse(saisie, out choix))
        {
            sasieValide = true;
        }
        else
        {
            Console.WriteLine("Saisie invalide entrer le bon numéro");
        }

    }
    switch (choix) 
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            List<Etudiant> etudiants = eRepo.AfficherToutLesEtudiants();

            if (etudiants.Count > 0)
            {
                foreach (Etudiant e in etudiants)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'étudiant");
            }
            break;
        case 2:
            try
            {
                int id = 0;
                Console.WriteLine("Entrer le prenom");
                string nom = Console.ReadLine();
                Console.WriteLine("Entrer un prenom");
                string prenom = Console.ReadLine();
                Console.WriteLine("Date de naissance");
                Console.Write("Année,Mois,Jour");
                int anne = int.Parse(Console.ReadLine());
                int mois = int.Parse(Console.ReadLine());
                int jour = int.Parse(Console.ReadLine());
                DateTime dateNaissance = new DateTime(anne,mois , jour);
                Console.WriteLine("Entrer le mail");
                string email= Console.ReadLine();
                Console.WriteLine("Entrer un nom");
                Etudiant etd = new Etudiant(nom, prenom, dateNaissance, email, id);
                etd.ValiderAge(dateNaissance);
                etd.ValiderEmail(email);
                etd.ValiderNom(nom);

                eRepo.AjouterUnEtudiant(etd);
                id++;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            break;
        case 3:
            try
            {
                int id;
                Console.WriteLine("Modifier un étudiant");
                Console.WriteLine("Quelle est son Id pour la modification");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrer un nom");
                string nom = Console.ReadLine();
                Console.WriteLine("Entrer un prenom");
                string prenom = Console.ReadLine();
                Console.WriteLine("Date de naissance");
                Console.Write("Année,Mois,Jour");
                int anne = int.Parse(Console.ReadLine());
                int mois = int.Parse(Console.ReadLine());
                int jour = int.Parse(Console.ReadLine());
                DateTime dateNaissance = new DateTime(anne, mois, jour);
                Console.WriteLine("Entrer le mail");
                string email = Console.ReadLine();
                
                eRepo.AjouterUnEtudiant(new Etudiant(nom, prenom, dateNaissance, email, id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            break;
        case 4 :
            Console.Write("Entrer l'Id de l'étudiant que vous voulez supppirmé :");
            int choixId = int.Parse(Console.ReadLine());
            eRepo.SupprimerUnEtudiant(choixId);
            break;
        case 5 :
            
                Console.WriteLine("Chercher un étudiant par son nom ou prenom");
            Console.WriteLine("Entrer le nom (appuyer sur entrer si vous ne le connaisais pas");
            string? choixNom = Console.ReadLine();
            Console.WriteLine("Entrer me prenom");
            string? choixPrenom = Console.ReadLine();
            Console.WriteLine(eRepo.ChercherEtudiantParNomOuPrenom(choixNom, choixPrenom));
            break;
            
    }

}
