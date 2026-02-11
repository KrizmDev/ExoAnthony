

using exo2EF.DbManager2;
using exo2EF.Model2;
using Microsoft.EntityFrameworkCore;

using (DbHotel db = new DbHotel())
{
    db.Database.Migrate();


    db.Add(new Client("pierre", "paul", "0598959575"));
    db.Add(new Client("poo", "gens", "0548475485"));
    db.Add(new Client("dsqd", "francoisee", "032559575"));

    db.Add(new Chambre(CStatus.libre, 3, 10.5));
    db.Add(new Chambre(CStatus.libre, 2, 7.5));
    db.Add(new Chambre(CStatus.libre, 1, 10.5));

    db.SaveChanges();

    List <Client> listeClient = db.clients.OrderBy(p => p.Nom).ToList();
    List <Chambre> listeChambre = db.chambres.ToList();
    List <Reservation> listeReservation = db.reservations.ToList();

    Client client1 = db.clients.Find(1);
    Client client2 = db.clients.Find(2);
    Client client3 = db.clients.Find(3);

    Chambre chambre1 = db.chambres.Find(1);
    Chambre chambre2 = db.chambres.Find(2);
    Chambre chambre3 = db.chambres.Find(3);

    db.SaveChanges();

    foreach (Client client in listeClient)
    {
        Console.WriteLine(client);
    }

    foreach (Chambre chambre in listeChambre)
    {
        if(chambre.Statut == CStatus.libre)
        {
            Console.WriteLine(chambre);
        }
    }

    db.Add(new Reservation(1, 2, etatResevation.Encours));
    db.Add(new Reservation(3, 3, etatResevation.Encours));


    db.SaveChanges();
    foreach (Reservation reservation in listeReservation) 
    {
    Console.WriteLine(reservation);
    
    }
}