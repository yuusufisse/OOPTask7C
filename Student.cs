using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask7C
{
    class Student
    {
        public Student(string name, string address, DateTime dateOfBirth)
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
