using exo1Entity.DbManager;
using exo1Entity.Model;
using Microsoft.EntityFrameworkCore;

using (DbAdresse db = new DbAdresse())
{
    db.Database.Migrate();



    db.Add(new Adresse("187", "generale delestraint", "", "douai", "59500"));
    db.Add(new Adresse("2", " delestraint", "", "lille", "59"));
    db.SaveChanges();

    Adresse a1 = db.adresse.Find(1);
    Console.WriteLine(a1);

    a1.Complement = "etg";


    db.Update(a1);

    Console.WriteLine(a1.Complement);

    db.adresse.Remove(a1);
    db.SaveChanges();
    List<Adresse>listAdresse = db.adresse.ToList();

    foreach(Adresse a in listAdresse)
    {
        Console.WriteLine(a);
    }

    


    
}