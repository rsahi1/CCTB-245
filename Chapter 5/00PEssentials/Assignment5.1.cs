using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00PEssentials


{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }


        public virtual void DisplayStudent()
        {
            Console.WriteLine("Id: {0} Name: {1} Phone): {2}", Id, Name, PhoneNumber);
        }
    }
}
