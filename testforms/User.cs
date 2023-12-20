using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebra
{
    public class User
    {
        public string ID { get; private set; }
        public string username { get; private set; }
        public string password { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }

        public User(string ID, string username, string password, string name, string surname)
        {
            this.ID = ID;
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
        }

        public string getID() {  return ID;}

        public string getUsername() { return username;}

        public string getPassword() { return password;}

        public string getName() { return name;}

        public string getSurname() { return surname;}
    }
}
