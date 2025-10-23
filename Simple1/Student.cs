using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
{
    internal class Student
    {
        public int[] marks = new int[3];

        public Student() {
        this.marks = new int[3];
        }

        public void input()
        {

            Console.WriteLine("Student marks");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public int totalsum(int[] marks)
        {
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            return total;
        }

        public float average(int[] marks)
        {
            int total = totalsum(marks);
            return total / marks.Length;
        }
    }
    class Person : Student
    {
        string name;
        int age;

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }




        public Person()
        {
            name = "";
            age = 0;
        }

        //Parameterized Constructor
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public void input1()
        {
            Console.WriteLine("Student name ");
            name = Console.ReadLine();
            Console.WriteLine("Student age ");
            age = Convert.ToInt32(Console.ReadLine());
        }

    }

    class StudentId : Person
    {
        public int id;

        public StudentId()
        {
                       id = 0;
        }

        public StudentId(int id,string name,int age) : base(name,age)
        {
            this.id = id;
        }
    }

    class StudentGrade : Student
    {
        public String grade;

        public StudentGrade()
        {
            grade = "F";
        }

        public StudentGrade(string grade)
        {
            this.grade = grade;
        }

        
    }
}
