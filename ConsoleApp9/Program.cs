using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Prayuth", "48763245");
            try
            {
                s.GPA = 7.5f;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
 
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }

    class Student
    {
        // Parameterized contructor
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        // Fields
        private string name;
        private string id;
        private float gpa;

        // Properties (read/write)
        public string Name
        {
            get { return name; }    // getter accessor
            //set { name = value; }   // setter accessor
        }

        public string ID
        {
            get { return id; }
            //set { id = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set
            {
                if((value <= 4.00f) && (value > 0.0f))
                   gpa = value;
                else
                    throw new Exception("GPA is not valid.");
            }
        }

        public override string ToString()
        {
            return string.Format("Name :{0}, ID:{1}, GPA:{2}",
                name, id, gpa);
        }
    }

}
