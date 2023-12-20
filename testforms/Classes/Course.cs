using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes
{
    public class Course
    {
        public string ID { get; private set; }
        public string name { get; private set; }
        public string lecturerID { get; private set; }

        public Course(string ID, string name, string lecturerID)
        {
            this.ID = ID;
            this.name = name;
            this.lecturerID = lecturerID;
        }

        public Course(string name, string lecturerID)
        {
            this.name = name;
            this.lecturerID = lecturerID;
        }

        public string getID() { return ID; }

        public string getName() { return name; }

        public string getlecturerID() { return lecturerID; }
    }
}
