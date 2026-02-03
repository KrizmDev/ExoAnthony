using exo19.Class;

Caisse caisse = new Caisse();


Vente v1 = caisse.ajoutVente(0);
DateTime date = DateTime.Now;

Console.WriteLine("===Caisse enregistreuse===");

while (true)
{
    Console.WriteLine("1=== Gestion de stock");
    Console.WriteLine("2===Vente Produit");
    Console.WriteLine("0===Quitter");

    int choix;
    bool isValid;

    
    do
    {
        Console.Write("Faite votre choix: ");
        string input = Console.ReadLine();
        isValid = int.TryParse(input, out choix);

        if (!isValid)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

    } while (!isValid);

    switch (choix) 
    { 
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Console.WriteLine("===Gestion de stock===");
            Console.WriteLine();
            Console.WriteLine("1===Ajout de Produit");
            Console.WriteLine("2===Voir tout les produits");
            Console.WriteLine("3===Voir toute les ventes");
            Console.WriteLine("0===Retour");
            Console.WriteLine();

            do
            {
                Console.Write("Faite votre choix: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out choix);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (!isValid);

            switch (choix) 
            {
                case 0:
                    return;
                case 1:
                    Console.Write("Id Produit :");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nom du produit :");
                    string nom = Console.ReadLine();
                    Console.Write("Prix du produit :");
                    double prix = double.Parse(Console.ReadLine());
                    Console.Write("Quantité disponible :");
                    int quantite = int.Parse(Console.ReadLine());
                    Produit p = new Produit(id, nom, prix, quantite);
                    caisse.ajoutProduit(p);
                    break;
                case 2:
                    caisse.afficherProduit();
                    break;
                case 3: 
                    caisse.afficherVente();
                    break;

            }
            break;
        case 2:
            Console.WriteLine("===Vente de produit===");
            List<Produit> panier = new List<Produit>();
            int idVente = 1;
            Vente vente = caisse.ajoutVente(idVente);
            idVente++;
            caisse.afficherProduit();
            Console.WriteLine("Entrer l'id des Porduits que vous voulez acheter");
            Console.WriteLine("Si vous n'avez plus de produit a acheter entrer 9999");
            while(true)
            {

                int choixID = int.Parse(Console.ReadLine());
                Produit produitChoisi = caisse._produit.Find(P => P._numero == choixID);
                if (produitChoisi != null)
                {
                    panier.Add(produitChoisi);
                    vente.ajoutProduit(produitChoisi);
                }
                else
                {
                    Console.WriteLine("Produit non trouvé :");
                }
                if(choixID == 9999)
                {
                    break;
                }


            }
            double total = 0;
            foreach (Produit p in panier)
            {
                total += p._prix;
            }
            Console.WriteLine($"Vous devez {total} euro");
            Console.WriteLine();
            Console.WriteLine("1===Par carte");
            Console.WriteLine("2===Par espece");
            Console.WriteLine("0===Abbandonner");
            do
            {
                Console.Write("Faite votre choix: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out choix);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (!isValid);
               
            switch (choix)
            {
                case 0:
                    Environment.Exit(0);
                    vente.Anulation();
                    break;
                case 1:
                    Console.WriteLine("Entrer vos numéro de carte");
                    string cbCode = Console.ReadLine();
                    PaiementCB cb = new PaiementCB(cbCode, idVente, date);
                    cb.Payer(total);
                    vente.Validation();
                    break;
                case 2:
                    PaiementEspece espece = new PaiementEspece(idVente, date);
                    espece.Payer(total);
                    vente.Validation();
                    break;
            }


            break;



    }
}