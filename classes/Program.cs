using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("kai", "dale", 12);

          
        }
    }

    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private bool sitting;
        private int steps;

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            sitting = true;
            steps = 0;
        }

        public void sit()
        {

            if (sitting)
            {
                Console.WriteLine($"{firstname} {lastname} is already sitting");
            }
            else
            {
                sitting = true;
            }

        }

        public void stand()
        {
            if (sitting)
            {
                sitting = false;
            }
        }           
        
          
    }

}
