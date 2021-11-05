using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region (1)
            //var query = SampleData.Books.Select(b => new { b.Title, b.Isbn });

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region (2)

            //var query = SampleData.Books.Where(b => b.Price > 25).Take(3);

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region (3)

            //var query = SampleData.Books.Select(b => new { b.Title, b.Publisher.Name });  //Query Operator

            //var q1 = from b in SampleData.Books            //Query Expression
            //         select new { b.Title, b.Publisher.Name };



            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"Book Title: {item.Title} \t , Publisher Name: {item.Name} ");
            //}


            #endregion

            #region (4)

            //int count = SampleData.Books.Where(b => b.Price > 20).Count();

            //Console.WriteLine($"the number of books which cost more than 20: {count} ");

            #endregion

            #region (5)

            //var query = SampleData.Books.Select(b => new { b.Title, b.Price, b.Subject.Name })
            //    .OrderBy(b => b.Name)
            //    .ThenByDescending(b => b.Price);



            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Title: {item.Title} \t :: Price(Descending):{item.Price} \t :: subject(Ascending): {item.Name})");
            //}


            #endregion

            #region (6)

            ////method1

            //var query1 = SampleData.Subjects.Select(s => new
            //{
            //    Sub = s.Name,
            //    Books = SampleData.Books.Where(b => b.Subject.Name == s.Name).Select(b => new { b.Title })
            //});

            //foreach (var item in query1)
            //{
            //    Console.WriteLine($"Subject: {item.Sub} \t Books#: {item.Books.Count()}");
            //    foreach (var bks in item.Books)
            //    {
            //        Console.WriteLine($"Book Name: {bks.Title}");
            //    }
            //    Console.WriteLine("---------------------------");
            //}

            //Console.WriteLine("\n************************************************************\n");


            ////Method 2

            //var query2 =
            //    from s in SampleData.Subjects
            //    select new
            //    {
            //        Sub = s.Name,
            //        Books =
            //            from bks in SampleData.Books
            //            where bks.Subject.Name == s.Name
            //            select new { bks.Title, bks.Price }
            //    };

            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"Subject: {item.Sub} \t Books#: {item.Books.Count()}");
            //    foreach (var bks in item.Books)
            //    {
            //        Console.WriteLine($"Book Name: {bks.Title}, Book Price: {bks.Price}");
            //    }
            //    Console.WriteLine("---------------------------");
            //}

            #endregion

            #region (7)

            ArrayList arrList = SampleData.GetBooks();
            var query = from  list.Cast(arrList)
                        select b;

            foreach (var item in query)
            {
                Console.WriteLine($"Book Title: {item.Title} \t Book Price : {item.Price} \t Book Subject : {item.Subject}");
            }

            #endregion

            #region (8)

            //var query =
            //    SampleData.Books.GroupBy(ps => new
            //    {
            //        ps.Publisher,
            //        ps.Subject
            //    }).OrderBy(p => p.Key.Publisher.Name)
            //    .ThenBy(s => s.Key.Subject.Name).Select(b => new
            //    {
            //        Publisher = b.Key.Publisher,
            //        Subject = b.Key.Subject,
            //        Books = b.OrderBy(x => x.Price)
            //    }); ;




            var query = SampleData.Books.GroupBy(ps => new { ps.Publisher, ps.Subject });

            foreach (var group in query)
            {
                Console.WriteLine($"Publisher: {group.Key.Publisher} \t Subject: {group.Key.Subject}");

                Console.WriteLine("===============================================================");

                foreach (var book in group)
                {
                    Console.WriteLine($"Name: {book.Title} \t Price: {book.Price}");
                }

            }


            #endregion


            Console.ReadLine();
        }
    }
}