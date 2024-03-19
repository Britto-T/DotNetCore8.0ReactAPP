using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myapp.DataContext.DataModels.General
{
    [Table("Persons", Schema ="dbo")]
    public class Persons
    {
        [Key]
        public int PersonId {get;set;}
        public string? LastName {get;set;}
        public string? FirstName {get;set;}
        public string? Address {get;set;}
        public string? City {get;set;}
    }
}