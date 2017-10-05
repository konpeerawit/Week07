using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Student
    {
        private string name;
        private string id;
        private float gpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public float GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }
}