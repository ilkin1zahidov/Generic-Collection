
using System;

namespace Generic_Collection
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Implicit,Explicit
            //Manat manat = new Manat(170);
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Generics
            //StringList list = new StringList();
            //list.Add("Ilkin");
            //list.Add("Code");
            //list.GetAll();

            //IntList list1 = new IntList();

            //list1.Add(1);
            //list1.Add(0);
            //list1.Add(2);
            //list1.GetAll();

            //BookList booklist = new BookList();

            //Book book1 = new Book()
            //{
            //    Name = "Xosrov ve Shirin",
            //    Author = "Nizami"
            //};
            //Book book2 = new Book()
            //{

            //    Name = "7 Gozel",
            //    Author = "Nizami"

            //};
            //Book book3 = new Book()
            //{

            //    Name = "Sosial Eksperiment",
            //    Author = "Elxan"

            //};
            //booklist.Add(book1);
            //booklist.Add(book2);
            //booklist.Add(book3);
            //booklist.GetAll();

            //DataList<string> stringList = new DataList<string>();
            //stringList.Add("Ilkin");
            //stringList.Add("Seid");
            //stringList.Add("Kenan");
            //stringList.Add("Rahid");

            //stringList.GetAll();

            //DataList<int> intList = new DataList<int>();
            //intList.Add(10);
            //intList.Add(11);
            //intList.Add(110);
            //intList.Add(101);

            //intList.GetAll();

            //Employee<string> emp1 = new Employee<string>();
            //Employee<int> emp2 = new Employee<int>();

            //Employee<Test> emp3 = new Employee<Test>();

            //Employee<Person, Common> employee = new Employee<Person, Common>();

            #endregion

            #region Operators overloading
            //Employee employee = new Employee(24, "Ilkin");
            //Student student = new Student(20, "Esger");
            //Console.WriteLine(employee>student);
            #endregion


            Kelvin kelvin = new Kelvin(5);
            Celsius celsius = kelvin;
            Console.WriteLine(celsius.Degree);

        }


        #region Implicit,Explicit

        //public class Dollar
        //{
        //    public double Usd { get; set; }
        //    public Dollar(double usd)
        //    {
        //        Usd = usd;

        //    }


        //}
        //public class Manat
        //{
        //    public double Azn { get; set; }
        //    public Manat(double azn)
        //    {
        //        Azn = azn;
        //    }

        //    public static explicit operator Dollar(Manat manat)
        //    {
        //        return new Dollar(manat.Azn / 1.7);
        //    }
        //}

        #endregion

       

        public class Kelvin
        {
            public double Degree { get; set; }
            public Kelvin(double kelvin)
            {
                Degree = kelvin ;
            }

          
        }

        public class Celsius 
        {
            public double Degree { get; set; }
            public Celsius(double celsius)
            {
                Degree = celsius;
      
            }

            public static implicit operator Celsius(Kelvin kelvin)
            {
                return new Celsius(kelvin.Degree + 273.15);
            }
        }

        #region Generics

        //public class Employee<T,U>/* where T : class*/
        //                          //where T : struct     
        //                          //where T : Common
        //                          //where T : ITest
        //                          //where T : new ()
        //{

        //}
        //public class Person : Common
        //{

        //}
        //public abstract class  Common
        //{

        //}
        //public class Test : ITest
        //{ 

        //}
        //public  interface ITest 
        //{ 

        //}





        //public class StringList
        //{
        //    private string[] arr;
        //    public StringList()
        //    {
        //        arr = new string[0];
        //    }
        //    public void Add(string str)
        //    {
        //        Array.Resize(ref arr, arr.Length + 1);
        //        arr[arr.Length - 1] = str;
        //    }
        //    public void GetAll()
        //    {
        //        foreach (var item in arr)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}



        //public class intlist
        //{
        //    private int[] arr;
        //    public intlist()
        //    {
        //        arr = new int[0];
        //    }
        //    public void add(int m)
        //    {
        //        array.resize(ref arr, arr.length + 1);
        //        arr[arr.length - 1] = m;
        //    }
        //    public void getall()
        //    {
        //        foreach (var item in arr)
        //        {
        //            console.writeline(item);
        //        }
        //    }
        //}
        //public class booklist
        //{

        //    private book[] arr;
        //    public booklist()
        //    {
        //        arr = new book[0];
        //    }
        //    public void add(book book)
        //    {
        //        array.resize(ref arr, arr.length + 1);
        //        arr[arr.length - 1] = book;
        //    }
        //    public void getall()
        //    {
        //        foreach (var item in arr)
        //        {
        //            console.writeline(item.name + "-" + item.author);
        //        }
        //    }


        //}

        //public class book
        //{
        //    public string name { get; set; }
        //    public string author { get; set; }
        //}

        //public class DataList<T>
        //{
        //    private T[] arr;
        //    public DataList()
        //    {
        //        arr = new T[0];
        //    }
        //    public void Add(T data)
        //    {
        //        Array.Resize(ref arr, arr.Length + 1);
        //        arr[arr.Length - 1] = data;
        //    }
        //    public void GetAll()
        //    {
        //        foreach (var item in arr)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}

        #endregion
        #region Operators overloading
        //public class Student
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //    public Student(int age, string name)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        //public class Employee 
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //    public Employee(int age, string name)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //    public static bool operator > (Employee employee, Student student) 
        //    {
        //        return employee.Age > student.Age;
        //    }
        //    public static bool operator <(Employee employee, Student student)
        //    {
        //        return employee.Age < student.Age;
        //    }
        //}

        #endregion




    }
}
 