using System;

namespace Domain.Entity
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string EmailAddress { get; set; } 
        public string Password { get; set; } 
        public string Salt { get; set; }

        protected User(int id, string firstName, string lastName, string username, string emailAddress, string password)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }

        protected User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        protected User(int id, string firstName, string lastName, string emailAddress, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}