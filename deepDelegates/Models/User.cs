using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace deepDelegates.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string AddressFirstline { get; set; }

        public string AddressSecondline { get; set; }

        public string AddressCity { get; set; }

        public string PostCode { get; set; }

    }

}