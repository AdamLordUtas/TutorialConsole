using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialConsole
{

    class Program
    {
        static List<Employee> FilterByGender(List<Employee> staff, string gender)
        {
            List<Employee> fList = new List<Employee>();

            foreach (var item in staff)
            {
                if (item.gender == gender)
                {
                    fList.Add(item);
                }
            }

            return fList;
        }

        static void Main(string[] args)
        {
            //Employee e = new Employee { name = "Greg", id = 5, gender = "m" };
            //Console.WriteLine(e.ToString());

            List<Employee> e = new List<Employee>() {
                new Employee {name = "John", id = 5, gender = "m" },
                new Employee {name = "Greg", id = 7, gender = "m" },
                new Employee {name = "Sara", id = 10, gender = "f" },
                new Employee {name = "Kkkkszkz", id = 2, gender = "x" }
            };

            /*            foreach (var item in e)
                        {
                            Console.WriteLine(item.ToString());
                        }*/

            List<Employee> fList = FilterByGender(e, "m");

            foreach (var item in fList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
