using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EXO_1ADO.Excepetions;

namespace EXO_1ADO.Class
{
    internal class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }


        public Etudiant(string nom , string prenom , DateTime dateDeNaissance,string email,int id)
        {
          

            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Email = email;
            Id = id;
        }

        public override string ToString()
        {
            return $"nom = {Nom} {Prenom}, Date de Naissance : {DateDeNaissance} , Email : {Email} Id : {Id}";
        }
        public void ValiderNom(string nom)
        {
            if (string.IsNullOrWhiteSpace(nom))
                throw new NomObligatoireException();
        }

        public void ValiderEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new EmailObligatoireException();

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern))
                throw new EmailInvalideException();
        }

        public void ValiderAge(DateTime dateNaissance)
        {
            int age = CalculerAge(dateNaissance);

            if (age < 0 || age > 120)
                throw new AgeInvalideException();
        }

        public int CalculerAge(DateTime dateNaissance)
        {
            int age = DateTime.Today.Year - dateNaissance.Year;
            if (dateNaissance.Date > DateTime.Today.AddYears(-age))
                age--;

            return age;
        }
    }
}
