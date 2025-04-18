using Assignment_2104001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{
    internal partial class DVD : Media<string>//partial class to store all linq operation methods
    {
        //linq operation to filrer dvds by genre

        public static void FilterDVsByGenre(List<Media<string>> medialist, string genre)
        {
            IEnumerable<DVD> dvds = medialist.OfType<DVD>().Where(c => c.Genre == genre);
            foreach (DVD dvd in dvds)
            {
                dvd.showdetails();
            }
        }
        //linq operation to filter dvds by year
        public static void FilterDVsByYear(List<Media<string>> medialist, int year)
        {
            IEnumerable<DVD> dvds = medialist.OfType<DVD>().Where(c => c.ReleaseYear == year);
            foreach (DVD dvd in dvds)
            {
                dvd.showdetails();
            }
        }
        //linq operation to filter dvds by director
        public static void FilterDVsByDirector(List<Media<string>> medialist, string director)
        {
            IEnumerable<DVD> dvds = medialist.OfType<DVD>().Where(c => c.Director == director);
            foreach (DVD dvd in dvds)
            {
                dvd.showdetails();
            }
        }
        //linq to groupby dvds by genre
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
        //linq to groupby dvds by year
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
        //linq to delete dvds by genre
        public static void DeleteDVDsByGenre(List<Media<string>> medialist, string genre)
        {
            int l=medialist.Count();
            for(int i = 0; i < l; i++)
            {
                if (medialist[i] is DVD)
                {
                    DVD dvd = (DVD)medialist[i];
                    if (dvd.Genre == genre)
                    {
                        medialist.Remove(dvd);
                        i--;
                        l--;
                    }
                }
            }
        }
        //linq to delete dvds by year
        public static void DeleteDVDsByYear(List<Media<string>> medialist, int year)
        {
            int l = medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is DVD)
                {
                    DVD dvd = (DVD)medialist[i];
                    if (dvd.ReleaseYear == year)
                    {
                        medialist.Remove(dvd);
                        i--;
                        l--;
                    }
                }
            }
        }
        //linq to delete dvds by director
        public static void DeleteDVDsByDirector(List<Media<string>> medialist, string director)
        {
            int l = medialist.Count();
            for (int i = 0; i < l; i++)
            {
                if (medialist[i] is DVD)
                {
                    DVD dvd = (DVD)medialist[i];
                    if (dvd.Director == director)
                    {
                        medialist.Remove(dvd);
                        i--;
                        l--;
                    }
                }
            }
        }

        //Linq to sort dvds by title
        public static void SortDVDsByTitle(List<Media<string>> medialist)
        {
            IEnumerable<DVD> dvds = medialist.OfType<DVD>().OrderBy(c => c.Title);
            foreach (DVD dvd in dvds)
            {
                dvd.showdetails();
            }
        }
        //linq to sort dvds by year
        public static void SortDVDsByYear(List<Media<string>> medialist)
        {
            IEnumerable<DVD> dvds = medialist.OfType<DVD>().OrderBy(c => c.ReleaseYear);
            foreach (DVD dvd in dvds)
            {
                dvd.showdetails();
            }
        }
        //linq to sort dvds by director
        public static void SortDVDsByDirector(List<Media<string>> medialist)
        {
            IEnumerable<DVD> dvds = medialist.OfType<DVD>().OrderBy(c => c.Director);
            foreach (DVD dvd in dvds)
            {
                dvd.showdetails();
            }
        }
        // LINQ to get the oldest DVD year
        public static int OldestDVDYear(List<Media<string>> medialist)
        {
            int oldestbook = medialist.OfType<DVD>().Min(ch => ch.ReleaseYear);
            return oldestbook;
            //Console.WriteLine($"Oldest DVD Year: {oldestbook}");
        }
        // LINQ to get the newest DVD year
        public static int NewestDVDYear(List<Media<string>> medialist)
        {
            int newestdvdyear = medialist.OfType<DVD>().Max(c => c.ReleaseYear);
            return newestdvdyear;
            //Console.WriteLine($"Newest DVD Year: {newestdvdyear}");
        }

        //linq to get total DVD count
        public static int TotalDVDCount(List<Media<string>> medialist)
        {
            int totaldvdcount = medialist.OfType<DVD>().Count();
            return totaldvdcount;
            //Console.WriteLine($"Total DVD Count: {totaldvdcount}");
        }
    }
}
