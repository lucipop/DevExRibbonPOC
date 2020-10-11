using System.Collections.Generic;
using System.ComponentModel;

namespace DXRibbon.Seed.Masterdata
{
    public class UsersSeed
    {
        public static IList<User> SeedList()
        {
            IList<User> clients = new List<User>
            {
                new User("AA", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("FF", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("BB", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("CC", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("DD", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("EE", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("FF", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("GG", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("HH", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("II", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
                new User("JJ", "test@gmai.com", "Andrei Pop", "+40 22 22 22"),
            };

            return clients;
        }

        public class User
        {
            [DisplayName("Admin")]
            public string Admin { get; set; }
            [DisplayName("Username")]
            public string  Username { get; set; }
            [DisplayName("Nume complet")]
            public string FullName { get; set; }
            [DisplayName("Tel.de serviciu")]
            public string Phone { get; set; }
            public User(string admin, string username, string fullname, string phone)
            {
                Admin = admin;
                Username = username;
                FullName = fullname;
                Phone = phone;
            }
        }
    }
}
