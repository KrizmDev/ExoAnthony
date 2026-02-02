using Exo14.Class;
Adresse adr = new Adresse(12, "Rue Victor Hugo", "Paris", "75001");

User alice = new User("Dupont", "Alice", adr);
User bob = new User("Martin", "Bob", adr);

Lettre lettre = new Lettre(alice, bob, "Bonjour Bob !");
lettre.Envoyer();
lettre.Lire();

Console.WriteLine(lettre);