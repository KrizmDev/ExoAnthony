using exo_18.Class;


Bibliotheque bibliotheque = new Bibliotheque();
Livre livre = new Livre(1,"titre","auteur",5);
Livre livre1 = new Livre(2, "titre2", "auteur2", 5);
Livre livre2 = new Livre(3, "titre3", "auteur3", 5);



bibliotheque.ajouterUnLivre(new Livre(1, "titre", "auteur", 5));
bibliotheque.ajouterUnLivre(new Livre(2, "titre2", "auteur2", 2));
bibliotheque.ajouterUnLivre(new Livre(3, "titre3", "auteur3", 10));

bibliotheque.afficherTout();
bibliotheque.RechercherUnLivre("titre3");
bibliotheque.RechercherUnLivre("auteur2");
bibliotheque.supprimerUnLivre(1);
bibliotheque.afficherTout();