using EXO_2_ADO.Class;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
namespace EXO_2_ADO.Repository
{
    internal class CommandeRepository
    {
        string connectionString = "Server=localhost;uid=root;Pwd=;Database=adoexo2";

        public void CreateTableClient()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string Query = """
                    
                    CREATE TABLE IF NOT EXISTS Clients(
                    id_client INT AUTO_INCREMENT PRIMARY KEY,
                    nom VARCHAR(255) NOT NULL,
                    prenom VARCHAR(255)NOT NULL,
                    adresse VARCHAR(255),
                    codePostal VARCHAR(255),
                    ville VARCHAR(255),
                    tel VARCHAR(255)
                    );
                    
                    """;

                using (MySqlCommand command = new MySqlCommand(Query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public void CreateTableCommande()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string Query = """
                    
                    CREATE TABLE IF NOT EXISTS Commandes(
                    id_commandes INT AUTO_INCREMENT PRIMARY KEY,
                    id_client int NOT NULL,
                    total DECIMAL(10,2) NOT NULL,
                    date_commande DATETIME,
                    CONSTRAINT fk_Clients
                    FOREIGN KEY (id_client)
                    REFERENCES Clients(id_client)
                    ON DELETE CASCADE
                    ON UPDATE CASCADE
                    );
                    
                    """;

                using (MySqlCommand command = new MySqlCommand(Query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public List <Clientt> AfficherLesClients()
        {
            List<Clientt> clients = new List<Clientt>();
            using (MySqlConnection connection = new MySqlConnection(connectionString)) 
    {
        connection.Open();
        string query = $"SELECT * FROM Clients";

        using (MySqlCommand command = new MySqlCommand( query, connection))
        {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        int id = reader.GetInt32("id_client");
                        string nom = reader.GetString("nom");
                        string prenom = reader.GetString("prenom");
                        string adresse = reader["adresse"] as string ?? "";
                        string codePostal = reader["codePostal"] as string ?? "";
                        string ville = reader["ville"] as string ?? "";
                        string tel = reader["tel"] as string ?? "";

                        Clientt client = new Clientt(id, nom, prenom, adresse, codePostal, ville, tel);
                        clients.Add(client);
                    }
                }
            }
            return clients;
        }
        public void AjouterUnClient(Clientt c)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO Clients (nom,prenom,adresse,codePostal,ville,tel)" +
                    $"VALUES (@nom,@prenom,@adresse,@codePostal,@ville,@tel)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@nom", c.nom);
                    command.Parameters.AddWithValue("@prenom", c.prenom);
                    command.Parameters.AddWithValue("@adresse", c.adresse);
                    command.Parameters.AddWithValue("@codePostal", c.codePostal);
                    command.Parameters.AddWithValue("@ville", c.ville);
                    command.Parameters.AddWithValue("@tel", c.tel);

                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbInsertion} Insertion");
                }

            }
        }
        public void ModifierUnEtudiant(Clientt c)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

            {
                connection.Open();
                string query = @"
                    UPDATE Clients SET
                        nom = @nom,
                        prenom = @prenom,
                        adresse = @adresse,
                        codePostal = @codePostal,
                        ville = @ville,
                        tel = @tel
                    WHERE id_client = @id_client";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_client", c.id);
                    command.Parameters.AddWithValue("@nom", c.nom);
                    command.Parameters.AddWithValue("@prenom", c.prenom);
                    command.Parameters.AddWithValue("@adresse", c.adresse);
                    command.Parameters.AddWithValue("@codePostal", c.codePostal);
                    command.Parameters.AddWithValue("@ville", c.ville);
                    command.Parameters.AddWithValue("@tel", c.tel);
                    int nbModification = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbModification} Modification");
                }

            }
        }
        public void SupprimerUnCLient(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM Clients WHERE id_client=@id_client;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id_client", id);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbSuppression} suppression");
                }
            }

        }
        public Clientt InfoClient(int id)
        {
            Clientt client = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
        SELECT id_client, nom, prenom, adresse, codePostal, ville, tel
        FROM Clients 
        WHERE id_client = @id;
    ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            client = new Clientt(
                                reader.GetInt32("id_client"),
                                reader.GetString("nom"),
                                reader.GetString("prenom"),
                                reader["adresse"] as string ?? "",
                                reader["codePostal"] as string ?? "",
                                reader["ville"] as string ?? "",
                                reader["tel"] as string ?? ""
                            );
                        }
                    }

                    if (client != null)
                    {
                        string query2 = @"
                SELECT id_commandes, date_commande, total
                FROM Commandes
                WHERE id_client = @id;
            ";
                        using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@id", id);
                            using (MySqlDataReader reader = command2.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                      Commande cmd = new Commande(
                                      reader.GetInt32("id_commandes"),
                                      id,
                                      reader.GetDateTime("date_commande"),
                                      reader.GetDecimal("total")
                                  );

                                }
                            }
                          
                        }
                    }
                }
            }
            return client;
        }
                    
        public void AjouterCommande(Commande commande)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            INSERT INTO Commandes (id_client, total, date_commande)
            VALUES (@id_client, @total, @date_commande);
        ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_client", commande.id_client);
                    command.Parameters.AddWithValue("@total", commande.tot);
                    command.Parameters.AddWithValue("@date_commande", commande.dateCommande);

                    int nbInsertionCommande = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbInsertionCommande} commande ajoutée");
                }
            }
        }
    }
}
