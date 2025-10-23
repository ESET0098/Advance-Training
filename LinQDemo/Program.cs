using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinQDemo.Program;

namespace LinQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            List<Person> people = new List<Person>
//            {
//                new Person { Name = "Alice", age = 30 },
//                new Person { Name = "Bob", age = 25 },
//                new Person { Name = "Charlie", age = 35 },
//                new Person { Name = "David", age = 28 }
//            };

//            var adults = from person in people
//                         where person.age >= 30
//                         orderby person.Name
//                         select person;

//            foreach (var person in adults)
//            {
//                Console.WriteLine($"{person.Name}, {person.age}");
//            }

//            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            var even = from n in num
//                       where n % 2 == 0
//                       select n;

//            foreach (var n in even)
//            {
//                Console.WriteLine(n);
//            }



//            List<Order> orders = new List<Order>
//{
//    new Order { OrderId = 1, CustomerId = 101, Amount = 45.50m },
//    new Order { OrderId = 2, CustomerId = 102, Amount = 120.00m },
//    new Order { OrderId = 3, CustomerId = 101, Amount = 75.00m },
//    new Order { OrderId = 4, CustomerId = 103, Amount = 200.00m },
//    new Order { OrderId = 5, CustomerId = 102, Amount = 30.00m }
//};
//            var customerTotalsQuery =
//        from order in orders
//        group order by order.CustomerId into orderGroup
//        where orderGroup.Sum(o => o.Amount) > 100
//        select new // 3. Project the final result
//        {
//            CustomerId = orderGroup.Key,
//            TotalAmount = orderGroup.Sum(o => o.Amount)
//        };

//            foreach (var customerTotal in customerTotalsQuery)
//            {
//                Console.WriteLine($"CustomerId: {customerTotal.CustomerId}, Total Amount: {customerTotal.TotalAmount}");
//            }

//            bool exists = people.Any(p => p.Name == "Alice");
//            Console.WriteLine($"Exists: {exists}");

//            bool notexists = people.All(p => p.age > 20);
//            Console.WriteLine($"Not Exists: {notexists}");

//            var vale = people.Where(p => p.Name.Contains("Alice"));
//            foreach (var p in vale)
//            {
//                Console.WriteLine($"Name: {p.Name}, Age: {p.age}");
//            }

//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//            var conatining = num.Where(n=>numbers.Contains(n));
//            foreach (var n in conatining)
//            {
//                Console.WriteLine(n);
//            }


//            var notconatining = num.Where(n => !numbers.Contains(n));
//            foreach (var n in notconatining)
//            {
//                Console.WriteLine(n);
//            }

            List<Person> people = new List<Person>
            {
                new Person { CustomerId = 1, Name = "Alice", age = 30 },
                new Person { CustomerId = 2, Name = "Bob", age = 25 },
                new Person { CustomerId = 3, Name = "Charlie", age = 35 },
                new Person { CustomerId = 4, Name = "David", age = 28 }
            };

            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, Amount = 45.50m },
                new Order { OrderId = 2, CustomerId = 2, Amount = 120.00m },
                new Order { OrderId = 3, CustomerId = 1, Amount = 75.00m },
                new Order { OrderId = 4, CustomerId = 3, Amount = 200.00m },
                new Order { OrderId = 5, CustomerId = 2, Amount = 30.00m }
            };


            var query = from p in people
                        join o in orders on p.CustomerId equals o.CustomerId
                        select new
                        {
                            p.Name,
                            o.Amount
                        };

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Amount: {item.Amount}");
            //}

            //var subquery = from p in people
            //               where (from o in orders
            //                      select o.CustomerId).Contains(p.CustomerId)
            //               select p;

            //foreach (var person in subquery)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.age}");
            //}

            var selectmay = from p in people
                            select p;

            foreach (var person in selectmay)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.age}");
            }





        }

        }
}
