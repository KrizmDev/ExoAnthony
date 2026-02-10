using EXO_2_ADO.Class;
using EXO_2_ADO.Repository;
using MySqlX.XDevAPI;

CommandeRepository repo = new CommandeRepository();


repo.CreateTableClient();
repo.CreateTableCommande();
Console.WriteLine("Tables créées ou déjà existantes.");

Clientt client1 = new Clientt(0, "jean", "pierre", "8 rue des Fleurs", "75001", "Paris", "0254874564");
Clientt client2 = new Clientt(1, "Dupont", "Jean", "12 rue des Fleurs", "75001", "Paris", "0123456789");
repo.AjouterUnClient(client1);
repo.AjouterUnClient(client2);
Console.WriteLine("Client ajouté.");


List<Clientt> clients = repo.AfficherLesClients();
Console.WriteLine("Liste des clients :");
foreach (Clientt c in clients)
{
    Console.WriteLine(c);
}


int clientId = clients[0].id;
Commande commande1 = new Commande(0, clientId, DateTime.Now, 150.50m);
repo.AjouterCommande(commande1);
Console.WriteLine("Commande ajoutée.");

Clientt clientInfo = repo.InfoClient(clientId);
Console.WriteLine("Informations du client :");
Console.WriteLine(clientInfo);


repo.SupprimerUnCLient(2);
foreach (Clientt c in clients)
{
    Console.WriteLine(c);
}