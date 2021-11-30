using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialConsole
{
    class Employee
    {
        public string name;/employee name
        public int id;
        public string gender;

        public override string ToString()
        {
            return name+ " " + id.ToString() + " " + gender;
        }
    }
}
