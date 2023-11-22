using System.ComponentModel.DataAnnotations;

namespace ArrayAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] studentArray = new string[10] { "James John", "Dele Thomas", "Dele Mode", "Kelvin Kyle", "Darmain Jane", 
                "Atinuke Luke", "Lucas Casper", "Mimi Mike", "Blessing Collins", "Queen Mabel"};

            foreach(string listOfStudents in studentArray)
            {
                Console.WriteLine(Array.IndexOf(studentArray, listOfStudents) + 1 + ". " + listOfStudents);
            }


            //List of 10 students

            var studentList = new List<Student>()
            {
                new Student() {Name = "James John", Age = 12},
                new Student() {Name = "Dele Thomas", Age =15},
                new Student() {Name = "Dele Mode", Age = 12},
                new Student() {Name = "Atinuke Luke", Age =18},
                new Student() {Name = "Mimi Mike", Age = 15},
                new Student() {Name = "Blessing Collins", Age =18},
                new Student() {Name = "Queen Mabel", Age = 14},
                new Student() {Name = "Kelvin Kyle", Age =11},
                new Student() {Name = "Darmain Jane", Age = 10},
                new Student() {Name = "Lucas Casper", Age =113},
            };

            var details = from p in studentList
                          where p.Age == 18
                          select p;

            Console.WriteLine();
            Console.WriteLine("The following student are of the age of 18 ");
            foreach (var student in details)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    public class Student
    {
        public string Name { get; set; } 
        public int Age { get; set; }
    }
}