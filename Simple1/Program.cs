using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple1;


namespace Simple1
{

    //class Student
    //{
    //    private string name;
    //    public string Name   
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    private int age;
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }

    //    public Student()
    //    {
    //        age = 0;
    //        name = "";
    //    }

    //    public Student(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //}

    //class Student1
    //{
    //    public string name;
    //    public int age;
    //    public int[] marks = new int[3];

    //    //Parameterless Constructor
    //    public Student1(string name,int age, int[] marks)
    //    {
    //        this.name = name;
    //        this.age = age;
    //        this.marks = marks;

    //    }
    //    //Default Constructor
    //    public Student1()
    //    {
    //        name = "";
    //        age = 0;
    //        marks = new int[3];
    //    }   
    //    public void input()
    //    {
    //        Console.WriteLine("Student name ");
    //        name = Console.ReadLine();
    //        Console.WriteLine("Student age ");
    //        age = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Student marks");
    //        for (int i = 0; i < marks.Length; i++)
    //        {
    //            marks[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //    }
    //    public int totalsum(int[] marks)
    //    {
    //        int total = 0;
    //        for (int i = 0; i < marks.Length; i++)
    //        {
    //            total += marks[i];
    //        }
    //        return total;
    //    }
    //    public float average(int[] marks)
    //    {
    //        int total = totalsum(marks);
    //        return total / marks.Length;
    //    }
    //}

    //class Student
    //{

    //    public int[] marks = new int[3];

    //    public void input()
    //    {

    //        Console.WriteLine("Student marks");
    //        for (int i = 0; i < marks.Length; i++)
    //        {
    //            marks[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //    }

    //    public int totalsum(int[] marks)
    //    {
    //        int total = 0;
    //        for (int i = 0; i < marks.Length; i++)
    //        {
    //            total += marks[i];
    //        }
    //        return total;
    //    }

    //    public float average(int[] marks)
    //    {
    //        int total = totalsum(marks);
    //        return total / marks.Length;
    //    }
    //}
    //class Person : Student
    //{
    //    string name;
    //    int age;

    //    public string getName()
    //    {
    //        return name;
    //    }
    //    public int getAge()
    //    {
    //        return age;
    //    }
    //    public void setName(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void setAge(int age)
    //    {
    //        this.age = age;
    //    }




    //    public Person()
    //    {
    //        name = "";
    //        age = 0;
    //    }

    //    //Parameterized Constructor
    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public void input1()
    //    {
    //        Console.WriteLine("Student name ");
    //        name = Console.ReadLine();
    //        Console.WriteLine("Student age ");
    //        age = Convert.ToInt32(Console.ReadLine());
    //    }

        //    class Student
        //{
        //    public string name;
        //    public int age;
        //    public int[] marks = new int[3];

        //    public Student()
        //    {
        //        name = "";
        //        age = 0;
        //        marks = new int[3];
        //    }

        //    public void input()
        //    {
        //        Console.WriteLine("Name");
        //        name = Console.ReadLine();
        //        Console.WriteLine("age");
        //        age = Convert.ToInt32(Console.ReadLine());
        //    }

        //    public void input(int[] marks)
        //    {
        //        Console.WriteLine("Marks");

        //        for(int i = 0; i < marks.Length; i++)
        //        {
        //            marks[i] = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }

        //    public void input(string name, int age, int[] marks)
        //    {
        //        Console.WriteLine("Name");
        //        name = Console.ReadLine();
        //        Console.WriteLine("age");
        //        age = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Marks");

        //        for (int i = 0; i < marks.Length; i++)
        //        {
        //            marks[i] = Convert.ToInt32(Console.ReadLine());
        //        }

        //    }


        //}






    }
    internal class Program
    {
        int[] marks = new int[3];
        public static int TotalSum(int[] marks)
        {
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            return total;
        }
        //public static float Average(int total, int n)
        //{
        //    return total / n;
        //}

        public static float Average(int[] marks)
        {
            int total = TotalSum(marks);
            return total / marks.Length;
        }

        public static void input(int[] marks)
        {
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static int[] input1(int n)
        {
            int[] marks = new int[n];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            return marks;
        }

        static void Main(string[] args)
        {
        //------------------------------ Task1---------------------//
        //Console.WriteLine("Student name ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Student age ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Student marks");
        //int[] marks = { 100, 90, 95 };
        //int total = 0;
        //for (int i = 0; i < marks.Length; i++)

        //{
        //    total += marks[i];
        //}
        //float avg = total / marks.Length;

        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Average: " + avg);


        //------------------------Task2--------------//
        //Console.WriteLine("Student name ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Student age ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Student marks");

        //int[] marks = new int[3];
        //int total = 0;

        //for(int i = 0; i < marks.Length; i++)
        //{
        //    marks[i] = Convert.ToInt32(Console.ReadLine());
        //  total += marks[i];
        //}
        //float avg = total/marks.Length;

        //Console.WriteLine("Name" + name);
        //Console.WriteLine("Age" + age);
        //Console.WriteLine("Average" + avg);


        //-----------------------------------Task3------------------//
        //Console.WriteLine("Student name ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Student age ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Student marks");

        //int[] marks = new int[3];

        //for(int i = 0; i < marks.Length; i++)
        //{
        //    marks[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //int total = TotalSum(marks);
        //float avg = Average(total, marks.Length);

        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Average: " + avg);

        //-------------Task4------------
        //Console.WriteLine("Student name ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Student age ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Student marks");

        //int[] marks = new int[3];

        //for (int i = 0; i < marks.Length; i++)
        //{
        //    marks[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //float average = Average(marks);

        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Average: " + average);

        //-------------Task5------------
        //Console.WriteLine("Student name ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Student age ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Student marks");

        //int[] marks = new int[3];
        //input(marks);

        //float average = Average(marks);

        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Average: " + average);

        //-------------Task6------------
        //Console.WriteLine("Student name ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Student age ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Student marks");

        //int[] marks = input1(3);

        //float average = Average(marks);

        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Average: " + average);

        //-------------Task7------------

        //Student1 s = new Student1("kunal", 20,new int[] {100,90,90});
        ////s.input();
        //float average = s.average(s.marks);

        //Console.WriteLine("Name: " + s.name);
        //Console.WriteLine("Age: " + s.age);
        //Console.WriteLine("Average: " + average);


        //-------------Task8------------
        //Person p = new Person();
        //p.input1();
        //p.input();


        //float average = p.average(p.marks);
        //Console.WriteLine("Name: " + p.getName());
        //Console.WriteLine("Age: " + p.getAge());
        //Console.WriteLine("average: " + average);

        //------------------Task9-------------

        //Student s = new Student();
        //s.input();
        ////s.input(s.marks);
        ////s.input(s.name, s.age, s.marks);

        //Console.WriteLine("name " + s.name);
        //Console.WriteLine("age " + s.age);

        //---------------Task10-------------


        //Student s = new Student();
        //s.Name = "kunal";
        //s.Age = 20;

        //Console.WriteLine(s.Age);


        //--------------Task11-----------

        //StudentId s = new StudentId();
        // s.setName("kunal");
        //s.setAge(20);
        //s.id = 101;
        //int[] marks = new int[3];
        //s.input();


        //float average = s.average(s.marks);

        //Console.WriteLine("Name: " + s.getName());
        //Console.WriteLine("Age: " + s.getAge());
        //Console.WriteLine("average" + average);

        ///----------Task12---------
        //StudentGrade s = new StudentGrade();
        //s.input();

        //float average = s.average(s.marks);

        //if( average > 33)
        //{
        //    s.grade = "P";
        //    Console.WriteLine(s.grade);
        //}
        //else
        //{
        //    Console.WriteLine(s.grade);

        //}

        //----------Task13---------
        //Addi a = new Addi();
        //int result = a.sum(10, 20, 30);

        //Console.WriteLine(result);

        //-------Task14--------
        //Sum of the areas of two rectangle

        //Rectangle r1 = new Rectangle();
        //Rectangle r2 = new Rectangle(10,40,400);
        //r1.input();
        
        //int sum = Rectangle.total(r1,r2);
        //Console.WriteLine("sum " + sum);
        //Console.WriteLine("sumofarea" + r1.sumofArea(r2).area1);


        //---------Task15--------
        //int n;
        //Console.WriteLine("No of rectangles");
        //n = Convert.ToInt32(Console.ReadLine());
        //int sumofRectangle = 0; 
        //for (int i = 1; i <= n; i++)
        //{
        //    Rectangle ri = new Rectangle();
        //    ri.input();
        //    sumofRectangle += ri.area();
        //}

        //Console.WriteLine("Sum of Rectangle " + sumofRectangle);

        //---------Task16--------

        //Rectangle r1 = new Rectangle(10, 20);
        //Rectangle r2 = new Rectangle(20, 30);

        //double sumofArea = r1 + r2;
        //double areadiff = Math.Abs(r1 - r2);
        //Console.WriteLine("Sum of Area " + sumofArea);
        //Console.WriteLine("Area Difference " + areadiff);

        //---------Task17--------

        //Interface1 i1 = new A();
        //Interface1 i2 = new B();

        //i1.show();
        //i2.show();
        //i1.clas();  
        //i2.clas();



        //var myDog = new Dog();
        //myDog.MakeSound();

        //var chuahua = new Chihuahua();
        //chuahua.MakeSound();

        var shape1 = new Circle { Radius = 5, Color = "Red" };
        var shape2 = new Rectangle1 { Width = 4, Height = 6, Color = "Blue" };

        Console.WriteLine($"Area of the circle: {shape1.CalculateArea()}");
        Console.WriteLine($"Area of the rectangle: {shape2.CalculateArea()}");

        shape1.Display();
        shape2.Display();
















    }
}

