using Assignment_2104001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{
    internal partial class CD : Media<string>//partial class to store all linq operation methods
    {
        //linq to filter cds by genre
        public static void FilterCDsByGenre(List<Media<string>> medialist, string genre)
        {
            IEnumerable<CD> cds = medialist.OfType<CD>().Where(c => c.Genre == genre);
            foreach (CD cd in cds)
            {
                cd.showdetails();
            }
        }
        //linq to filter cds by year
        public static void FilterCDsByYear(List<Media<string>> medialist, int year)
        {
            IEnumerable<CD> cds = medialist.OfType<CD>().Where(c => c.ReleaseYear == year);
            foreach (CD cd in cds)
            {
                cd.showdetails();
            }
        }
        //linq to filter cds by singer
        public static void FilterCDsBySinger(List<Media<string>> medialist, string singer)
        {
            IEnumerable<CD> cds = medialist.OfType<CD>().Where(c => c.Singer == singer);
            foreach (CD cd in cds)
            {
                cd.showdetails();
            }
        }
        //linq ro groupby cds by genre
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
        //linq to groupby cds by year
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
        //linq to delete cds by genre
        public static void DeleteCDsByGenre(List<Media<string>> medialist, string genre)
        {
            int l=medialist.Count();
            for(int i = 0; i < l; i++)
            {
                if (medialist[i] is CD)
                {
                    CD cds = (CD)medialist[i];
                    if (medialist[i].Genre == genre)
                    {
                        medialist.Remove(cds);
                        i--;
                        l--;
                    }
                }
            }
        }
        //linq to delete cds by year
        public static void DeleteCDsByYear(List<Media<string>> medialist, int year)
        {
            int l = medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is CD)
                {
                    CD cds = (CD)medialist[i];
                    if (medialist[i].ReleaseYear == year)
                    {
                        medialist.Remove(cds);
                        i--;
                        l--;
                    }
                }
            }

            }
        //linq to delete cds by title
        public static void DeleteCDsByTitle (List<Media<string>> medialist, string title)
        {
            int l = medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is CD)
                {
                    CD cds = (CD)medialist[i];
                    if (medialist[i].Title== title)
                    {
                        medialist.Remove(cds);
                        i--;
                        l--;
                    }
                }
            }
            }
            //linq to sort cds by title
            public static void SortCDsByTitle(List<Media<string>> medialist)
        {
            IEnumerable<CD> sortbytitle = medialist.OfType<CD>().OrderBy(c => c.Title);
            foreach (var media in sortbytitle)
            {
                media.showdetails();
            }
        }
        //linq to sort cds by year
        public static void SortCDsByYear(List<Media<string>> medialist)
        {
            IEnumerable<CD> sortbyyear = medialist.OfType<CD>().OrderBy(c => c.ReleaseYear);
            foreach (var media in sortbyyear)
            {
                media.showdetails();
            }
        }
        //linq to sort cds by singer
        public static void SortCDsBySinger(List<Media<string>> medialist)
        {
            IEnumerable<CD> sortbysinger = medialist.OfType<CD>().OrderBy(c => c.Singer);
            foreach (var media in sortbysinger)
            {
                media.showdetails();
            }
        }
        //linq to get oldest cd year
        public static int FindOldestCD(List<Media<string>> medialist)
        {
            int oldestcdyear = medialist.OfType<CD>().Min(c => c.ReleaseYear);
            return oldestcdyear;
            //Console.WriteLine($"Oldest CD :{oldestcdyear}");
        }
        //linq to find newest cd
        public static int FindNewestCD(List<Media<string>> medialist)
        {
            int newestcd = medialist.OfType<CD>().Max(c => c.ReleaseYear);
            return newestcd;
            //Console.WriteLine($"Newest CD : {newestcd}");
        }
        //linq for total cd count
        public static int TotalCDCount(List<Media<string>> medialist)
        {
            int totalcdcount = medialist.OfType<CD>().Count();
            return totalcdcount;
            //Console.WriteLine($"Total CD Count: {totalcdcount}");
        }
    }
}
