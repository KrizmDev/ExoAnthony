using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Models
{
    public class Student
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column("FirstName")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("LastName")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column ("Age")]
        [Range(0 , 120)]
        public int Age { get; set; }
        [Required]
        [Column("Email")]
        [EmailAddress]
        public string Email { get; set; }


        public Student() { }

        public Student ( string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

        public override string ToString()
        {
             return $"{FirstName} {LastName} {Age} {Email}";
        }
    }
}
