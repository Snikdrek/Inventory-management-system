using Assignment_2104001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{
    internal partial class Books : Media<string>//partial class to store all linq operation methods
    {
        //linq operation to filrer books by genre
        public static void FilterBooksByGenre(List<Media<string>> medialist, string genre)
        {
            IEnumerable<Books> books = medialist.OfType<Books>().Where(c => c.Genre == genre);
            foreach (Books book in books)
            {
                book.showdetails();
            }
        }
        //linq operation to filter books by year
        public static void FilterBooksByYear(List<Media<string>> medialist, int year)
        {
            IEnumerable<Books> books = medialist.OfType<Books>().Where(c => c.ReleaseYear == year);
            foreach (Books book in books)
            {
                book.showdetails();
            }
        }
        //linq operation to filter books by writer
        public static void FilterBooksByWriter(List<Media<string>> medialist, string writer)
        {
            IEnumerable<Books> books = medialist.OfType<Books>().Where(c => c.Writer == writer);
            foreach (Books book in books)
            {
                book.showdetails();
            }
        }
        //linq to groupby books by genre
        public static void GroupByGenre(List<Media<string>> medialist)
        {
            var groupbygenre = medialist.GroupBy(c => c.Genre);
            foreach (var genre in groupbygenre)
            {
                Console.WriteLine($"Genre: {genre.Key}");
                foreach (var media in genre)
                {
                    media.showdetails();
                }
            }
        }
        //linq to groupby books by year
        public static void GroupByYear(List<Media<string>> medialist)
        {
            var groupbyyear = medialist.GroupBy(c => c.ReleaseYear);
            foreach (var year in groupbyyear)
            {
                Console.WriteLine($"Year: {year.Key}");
                foreach (var media in year)
                {
                    media.showdetails();
                }
            }
        }
        //linq to delete books by title
        public static void DeleteBooksByTitle(List<Media<string>> medialist, string title)
        {
            int l = medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is Books)
                {
                    Books book = medialist[i] as Books;
                    if (book.Title == title)
                    {
                        medialist.Remove(book);
                        i--;
                        l--;
                    }
                }
            }
        }
        //linq to delete books by genre
        public static void DeleteBooksByGenre(List<Media<string>> medialist, string genre)
        {
            int l=medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is Books)
                {
                    Books book = medialist[i] as Books;
                    if (book.Genre == genre)
                    {
                        medialist.Remove(book);
                        i--;
                        l--;
                    }
                }
            }
           
        }
        //linq to delete books by year
        public static void DeleteBooksByYear(List<Media<string>> medialist, int year)
        {
            int l = medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is Books)
                {
                    Books book = medialist[i] as Books;
                    if (book.ReleaseYear == year)
                    {
                        medialist.Remove(book);
                        i--;
                        l--;
                    }
                }
            }
        }
        //linq to sort books by title
        public static void SortBooksByTitle(List<Media<string>> medialist)
        {
            IEnumerable<Books> sortbytitle = medialist.OfType<Books>().OrderBy(c => c.Title);
            foreach (var title in sortbytitle)
            {
                title.showdetails();
            }
        }
        //linq to sort books by writer
        public static void SortBooksByWriter(List<Media<string>> medialist)
        {
            IEnumerable<Books> sortbywriter = medialist.OfType<Books>().OrderBy(c => c.Writer);
            foreach (var writer in sortbywriter)
            {
                writer.showdetails();
            }
        }
        //linq to sort books by year
        public static void SortBooksByYear(List<Media<string>> medialist)
        {
            IEnumerable<Books> sortbyyear = medialist.OfType<Books>().OrderBy(c => c.ReleaseYear);
            foreach (var year in sortbyyear)
            {
                year.showdetails();
            }
        }
        //linq to find the oldest book year
        public static int FindOldestBook(List<Media<string>> medialist)
        {
            int oldestbook = medialist.OfType<Books>().Min(c => c.ReleaseYear);

            return oldestbook;
            //Console.WriteLine($"Oldest book year{oldestbook}");

        }
        //linq to find the newest book year
        public static int FindNewestBook(List<Media<string>> medialist)
        {
            int newestbook = medialist.OfType<Books>().Max(c => c.ReleaseYear);
            return newestbook;
            //Console.WriteLine($"Newest book year{newestbook}");
        }
        //linq for total book count
        public static int TotalBookCount(List<Media<string>> medialist)
        {
            int totalbookcount = medialist.OfType<Books>().Count();
            return totalbookcount;
            //Console.WriteLine($"Total Book Count: {totalbookcount}");
        }
    }
}
