using System;
using System.ComponentModel.DataAnnotations;

namespace Firstcod.FC.Provider.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public long State { get; set; }
    }
}
