using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using EXO_1ADO.Class;
using MySql.Data.MySqlClient;

namespace EXO_1ADO.Repository
{
    internal class EtudiantRepository
    {
        string connectionString = "Server=localhost;uid=root;Pwd=;Database=adoexo1";
        public void AjouterUnEtudiant(Etudiant e)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO Etudiant (nom,prenom,dateDeNaissance,email)" +
                    $"VALUES (@nom,@prenom,@dateDeNaissance,@email)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@dateDeNaissance", e.DateDeNaissance);
                    command.Parameters.AddWithValue("@email", e.Email);
                    command.Parameters.AddWithValue("@id", e.Id);
                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbInsertion} Insertion");
                }

            }
        }

        public void ModifierUnEtudiant(Etudiant e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

            {
                connection.Open();
                string query = @"
                    UPDATE Etudiant SET
                        nom = @nom,
                        prenom = @prenom,
                        dateDeNaissance = @dateDeNaissance,
                        email = @email
                    WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@dateDeNaissance", e.DateDeNaissance);
                    command.Parameters.AddWithValue("@email", e.Email);
                    command.Parameters.AddWithValue("@id", e.Id);
                    int nbModification = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbModification} Modification");
                }

            }
        }
        public void SupprimerUnEtudiant(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM Etudiant WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine($"{nbSuppression} suppression");
                }
            }

        }
        public List<Etudiant> AfficherToutLesEtudiants()
        {
            List<Etudiant> etudiant = new List<Etudiant>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string Query = "Select * From Etudiant;";

                using (MySqlCommand command = new MySqlCommand(Query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string nom = reader["nom"] as string ?? "";
                        string prenom = reader["prenom"] as string ?? "";
                        DateTime dateNaissance = reader.GetDateTime("dateDeNaissance");
                        string email = reader["email"] as string ?? "";
                        int id = reader.GetInt32("id");

                        etudiant.Add(new Etudiant(nom, prenom, dateNaissance, email, id));
                            
                          
                    }

                }
            }
            return etudiant;
        }

        public void CreateTableEtudiant()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = """
                    CREATE TABLE IF NOT EXISTS Etudiant(
                    nom VARCHAR(255),
                    prenom VARCHAR(255),
                    dateDeNaissance DATE,
                    email VARCHAR(255) UNIQUE,
                    id int AUTO_INCREMENT PRIMARY KEY
                    );
                    """;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }

        public Etudiant ChercherEtudiantParNomOuPrenom(string? nom, string? prenom)
        {
            Etudiant etudiant;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT *
            FROM Etudiant
            WHERE prenom = @prenom
               OR nom = @nom";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@nom", nom);

                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    etudiant = new Etudiant(
                      reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("dateDeNaissance"),
                            reader.GetString("email"),
                            reader.GetInt32("id")
                      );
                }
            }
            return etudiant;
            
        }
    }
}
