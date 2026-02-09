using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_1ADO.Excepetions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    public class NomObligatoireException : ValidationException
    {
        public NomObligatoireException() : base("Le nom est obligatoire.") { }
    }

    public class EmailObligatoireException : ValidationException
    {
        public EmailObligatoireException() : base("L'email est obligatoire.") { }
    }

    public class EmailInvalideException : ValidationException
    {
        public EmailInvalideException() : base("Le format de l'email est invalide.") { }
    }

    public class AgeInvalideException : ValidationException
    {
        public AgeInvalideException() : base("L'âge doit être compris entre 0 et 120 ans.") { }
    }
}
