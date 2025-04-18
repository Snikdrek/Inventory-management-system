using Assignment__2104001;
using Assignment_2104001;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{


    class program
    {
        static void Main(string[] args)
        {
            List<Media<string>> medialist = new List<Media<string>>();//creating a list of media
            //adding items to the list
            medialist.Add(new Books(2000, "Harry Potter", "Fantasy", "J.K Rowling", "200"));
            medialist.Add(new Books(1965, "Dune", "Sci-Fi", "Frank Herbert", "500"));
            medialist.Add(new Books(1978, "The Stand", "Sci-Fi", "Stephen King", "430"));
            medialist.Add(new Books(1895, "The time machine", "Sci-Fi", "HG-Wells", "600"));
            medialist.Add(new Books(1978, "IT", "Horror", "Stephen King", "500"));
            medialist.Add(new Books(1987, "Misery", "Horror", "Stephen King", "500"));
            medialist.Add(new CD(2013, "Rap God", "Rap", "Eminem", "Dr.Dre"));
            medialist.Add(new CD(2002, "Lose Yourself", "Rap", "Eminem", "Dr.Dre"));
            medialist.Add(new CD(2002, "Numb", "Band", "Linkin Park", "Don Gilmore"));
            medialist.Add(new CD(2020, "In the end", "Band", "Linkin Park", "Don Gilmore"));
            medialist.Add(new CD(2019, "Someone you loved", "Sad Songs", "Lewis Capaldi", "Thomas Barnes"));
            medialist.Add(new CD(2000, "Let her go", "Sad Songs", "Passenger", "Mike Rosenberg "));
            medialist.Add(new DVD(2014, "Interstellar", "Sci-Fi", "Christopher Nolan", "Warner Bros"));
            medialist.Add(new DVD(2017, "Inception", "Sci-Fi", "Christopher Nolan", "Warner Bros"));
            medialist.Add(new DVD(2017, "The Conjuring", "Horror", "James Wan", "Universal"));
            medialist.Add(new DVD(2019, "The Conjuring 2", "Horror", "James Wan", "Universal"));
            medialist.Add(new DVD(2000, "Harry Potter", "Fantasy", "David Yates", "Warner Bros"));
            medialist.Add(new DVD(2013, "Fantastic Beasts", "Fantasy", "David Yates", "Warner Bros"));



            while (true)
            {
            Start:
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("Enter 1 to add CD");
                Console.WriteLine("Enter 2 to add DVD");
                Console.WriteLine("Enter 3 to add Book");
                Console.WriteLine("Enter 4 to display all");
                Console.WriteLine("Enter 5 to filter out items");
                Console.WriteLine("Enter 6 to update items");
                Console.WriteLine("Enter 7 to delete items");
                Console.WriteLine("Enter 8 to sort items");
                Console.WriteLine("Enter 9 to make group of properties having a special simillar value");
                Console.WriteLine("Enter 10 to show statistics");
                Console.WriteLine("Enter 11 to display all books");
                Console.WriteLine("Enter 12 to display all CDs");
                Console.WriteLine("Enter 13 to display all DVDs");
                Console.WriteLine("Enter 14 to show system-runtime");
                Console.WriteLine("Enter 15 to exit");
                Console.WriteLine("*****************************************************************************");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    //we created a new cd obj
                    Console.WriteLine("Enter Release Year");
                    int ReleaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Title");
                    string Title = Console.ReadLine();
                    Console.WriteLine("Enter Genre");
                    string Genre = Console.ReadLine();
                    Console.WriteLine("Enter Singer");
                    string Singer = Console.ReadLine();
                    Console.WriteLine("Enter Producer");
                    string Producer = Console.ReadLine();
                    medialist.Add(new CD(ReleaseYear, Title, Genre, Singer, Producer));
                }
                else if (choice == 2)
                {
                    //we created a new dvd obj
                    Console.WriteLine("Enter Release Year");
                    int ReleaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Title");
                    string Title = Console.ReadLine();
                    Console.WriteLine("Enter Genre");
                    string Genre = Console.ReadLine();
                    Console.WriteLine("Enter Director");
                    string Director = Console.ReadLine();
                    Console.WriteLine("Enter Producer");
                    string Producer = Console.ReadLine();
                    medialist.Add(new DVD(ReleaseYear, Title, Genre, Director, Producer));

                }
                else if (choice == 3)
                {
                    //we created a new book obj
                    Console.WriteLine("Enter Release Year");
                    int ReleaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Title");
                    string Title = Console.ReadLine();
                    Console.WriteLine("Enter Genre");
                    string Genre = Console.ReadLine();
                    Console.WriteLine("Enter Writer");
                    string Writer = Console.ReadLine();
                    Console.WriteLine("Enter Pages");
                    string Pages = Console.ReadLine();
                    medialist.Add(new Books(ReleaseYear, Title, Genre, Writer, Pages));
                }
                else if (choice == 4)
                {
                    //showing all the items in the list
                    foreach (Media<string> media in medialist)
                    {
                        media.showdetails();
                    }
                }

                else if (choice == 5)
                {
                start1:
                    Console.WriteLine("By which you want to filter out items");
                    Console.WriteLine("1.to filter books");
                    Console.WriteLine("2.to filter CDs");
                    Console.WriteLine("3.to filter DVDs");
                    Console.WriteLine("4.Back");
                    int k = int.Parse(Console.ReadLine());
                    if (k == 1)
                    {
                        Console.WriteLine("1.Filter out by Genre");
                        Console.WriteLine("2.Filter out by ReleaseYear");
                        Console.WriteLine("3.Filter out by Writer");
                        Console.WriteLine("4.Back");
                        int k1 = int.Parse(Console.ReadLine());
                        {
                            if (k1 == 1)
                            {
                                Console.WriteLine("Enter genre");
                                string genre = Console.ReadLine();
                                Books.FilterBooksByGenre(medialist, genre);//calling the method to filter out books by genre by passing the medialist and genre as parameters
                            }
                            else if (k1 == 2)
                            {
                                Console.WriteLine("Enter releaseyear");
                                int releaseyear = Convert.ToInt32(Console.ReadLine());
                                Books.FilterBooksByYear(medialist, releaseyear);//calling the method to filter out books by year by passing the medialist and year as parameters
                            }
                            else if (k1 == 3)
                            {
                                Console.WriteLine("Enter writer");
                                string writer = Console.ReadLine();
                                Books.FilterBooksByWriter(medialist, writer);//calling the method to filter out books by writer by passing the medialist and writer as parameters
                            }
                            else
                            {
                                goto start1;//if the user enters 4 then it will go back to the start1
                            }
                        }
                    }
                    else if (k == 2)
                    {
                        Console.WriteLine("1.Filter out by Genre");
                        Console.WriteLine("2.Filter out by Release-Year");
                        Console.WriteLine("3.Filter out by Singer");
                        Console.WriteLine("4.Back");
                        int k2 = int.Parse(Console.ReadLine());
                        {
                            if (k2 == 1)
                            {
                                Console.WriteLine("Enter genre");
                                string genre = Console.ReadLine();
                                CD.FilterCDsByGenre(medialist, genre);//calling the method to filter out cds by genre by passing the medialist and genre as parameters
                            }
                            else if (k2 == 2)
                            {
                                Console.WriteLine("Enter releaseyear");
                                int releaseyear = Convert.ToInt32(Console.ReadLine());
                                CD.FilterCDsByYear(medialist, releaseyear);//calling the method to filter out cds by year by passing the medialist and year as parameters
                            }
                            else if (k2 == 3)
                            {
                                Console.WriteLine("Enter singer");
                                string singer = Console.ReadLine();
                                CD.FilterCDsBySinger(medialist, singer);//calling the method to filter out cds by singer by passing the medialist and singer as parameters
                            }
                            else
                            {
                                goto start1;//if the user enters 4 then it will go back to the start1
                            }
                        }
                    }
                    else if (k == 3)
                    {
                        Console.WriteLine("1.Filter out by Genre");
                        Console.WriteLine("2.Filter out by Release-Year");
                        Console.WriteLine("3.Filter out by Director");
                        Console.WriteLine("4.Back");
                        int k3 = int.Parse(Console.ReadLine());
                        {
                            if (k3 == 1)
                            {
                                Console.WriteLine("Enter genre");
                                string genre = Console.ReadLine();
                                DVD.FilterDVsByGenre(medialist, genre);//calling the method to filter out dvds by genre by passing the medialist and genre as parameters
                            }
                            else if (k3 == 2)
                            {
                                Console.WriteLine("Enter releaseyear");
                                int releaseyear = Convert.ToInt32(Console.ReadLine());
                                DVD.FilterDVsByYear(medialist, releaseyear);//calling the method to filter out dvds by year by passing the medialist and year as parameters
                            }
                            else if (k3 == 3)
                            {
                                Console.WriteLine("Enter director");
                                string director = Console.ReadLine();
                                DVD.FilterDVsByDirector(medialist, director);//calling the method to filter out dvds by director by passing the medialist and director as parameters
                            }
                            else
                            {
                                goto start1;//if the user enters 4 then it will go back to the start1
                            }
                        }
                    }
                    else if (k == 4)
                    {
                        goto Start;//if the user enters 4 then it will go back to the start
                    }
                  

                }
                else if (choice == 6)
                {
                    //edit cd,dvd, book by title
                    Console.WriteLine("By which you want to update you information");
                    Console.WriteLine("1.Update by Titile");
                    Console.WriteLine("2.Update by Genre");
                    Console.WriteLine("3.Update by Release Year");
                    Console.WriteLine("4.Back");
                    int y = int.Parse(Console.ReadLine());
                    {
                        if (y == 1)
                        {
                            
                            Console.WriteLine("Enter old Title");
                            string oldTitle = Console.ReadLine();
                            Console.WriteLine("Enter new Title");
                            string newTitle = Console.ReadLine();
                            foreach (var item in medialist)
                            {
                                if (item.Title == oldTitle)
                                {
                                    item.Title = newTitle;
                                }
                            }

                        }
                        else if (y == 2)
                        {
                            Console.WriteLine("Enter old Genre");
                            string oldGenre = Console.ReadLine();
                            Console.WriteLine("Enter new Genre");
                            string newGenre = Console.ReadLine();
                            foreach (var item in medialist)
                            {
                                if (item.Genre == oldGenre)
                                {
                                    item.Genre = newGenre;
                                }
                            }
                        }
                        else if (y == 3)
                        {
                            Console.WriteLine("Enter old Release Year");
                            int oldReleaseYear = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Release Year");
                            int newReleaseYear = Convert.ToInt32(Console.ReadLine());
                            foreach (var item in medialist)
                            {
                                if (item.ReleaseYear == oldReleaseYear)
                                {
                                    item.ReleaseYear = newReleaseYear;
                                }
                            }
                        }
                        else if (y == 4)
                        {
                            goto Start;
                        }

                    }


                }

                else if (choice == 7)
                {
                start2:
                    Console.WriteLine("By which you want to delete out items");
                    Console.WriteLine("1.to delete from books");
                    Console.WriteLine("2.to delete from CDs");
                    Console.WriteLine("3.to delete from DVDs");
                    Console.WriteLine("4.Back");
                    int q = int.Parse(Console.ReadLine());
                    if (q == 1)
                    {
                        Console.WriteLine("1.Delete by Title");
                        Console.WriteLine("2.Delete by Genre");
                        Console.WriteLine("3.Delete by Release Year");
                        Console.WriteLine("4.Back");
                        int q1 = int.Parse(Console.ReadLine());
                        {
                            if (q1 == 1)
                            {
                                Console.WriteLine("Enter title");
                                string title = Console.ReadLine();
                                Books.DeleteBooksByTitle(medialist, title);//calling the method to delete books by title by passing the medialist and title as parameters
                            }
                            else if (q1 == 2)
                            {
                                Console.WriteLine("Enter genre");
                                string genre = Console.ReadLine();
                                Books.DeleteBooksByGenre(medialist, genre);//calling the method to delete books by genre by passing the medialist and genre as parameters
                            }
                            else if (q1 == 3)
                            {
                                Console.WriteLine("Enter releaseyear");
                                int releaseyear = Convert.ToInt32(Console.ReadLine());
                                Books.DeleteBooksByYear(medialist, releaseyear);//calling the method to delete books by year by passing the medialist and year as parameters
                            }
                            else
                            {
                                goto start2;
                            }
                        }
                    }
                    else if (q == 2)
                    {
                        Console.WriteLine("1.Delete by Genre");
                        Console.WriteLine("2.Delete by Release Year");
                        Console.WriteLine("3.Delete by Title");
                        Console.WriteLine("4.Back");
                        int q2 = int.Parse(Console.ReadLine());
                        {
                            if (q2 == 1)
                            {
                                Console.WriteLine("Enter genre");
                                string genre = Console.ReadLine();
                                CD.DeleteCDsByGenre(medialist, genre);//calling the method to delete cds by genre by passing the medialist and genre as parameters
                            }
                            else if (q2 == 2)
                            {
                                Console.WriteLine("Enter releaseyear");
                                int releaseyear = Convert.ToInt32(Console.ReadLine());
                                CD.DeleteCDsByYear(medialist, releaseyear);//calling the method to delete cds by year by passing the medialist and year as parameters
                            }
                            else if (q2 == 3)
                            {
                                Console.WriteLine("Enter title");
                                string title = Console.ReadLine();
                                CD.DeleteCDsByTitle(medialist, title) ;//calling the method to delete cds by singer by passing the medialist and singer as parameters
                            }
                            else
                            {
                                goto start2;
                            }
                        }
                    }
                    else if (q == 3)
                    {
                        Console.WriteLine("1.Delete by Genre");
                        Console.WriteLine("2.Delete by Release Year");
                        Console.WriteLine("3.Delete by Director");
                        Console.WriteLine("4.Back");
                        int q3 = int.Parse(Console.ReadLine());
                        {
                            if (q3 == 1)
                            {
                                Console.WriteLine("Enter genre");
                                string genre = Console.ReadLine();
                                DVD.DeleteDVDsByGenre(medialist, genre);//calling the method to delete dvds by genre by passing the medialist and genre as parameters
                            }
                            else if (q3 == 2)
                            {
                                Console.WriteLine("Enter releaseyear");
                                int releaseyear = Convert.ToInt32(Console.ReadLine());
                                DVD.DeleteDVDsByYear(medialist, releaseyear);//calling the method to delete dvds by year by passing the medialist and year as parameters
                            }
                            else if (q3 == 3)
                            {
                                Console.WriteLine("Enter director");
                                string director = Console.ReadLine();
                                DVD.DeleteDVDsByDirector(medialist, director);//calling the method to delete dvds by director by passing the medialist and director as parameters
                            }
                            else
                            {
                                goto start2;//if the user enters 4 then it will go back to the start2
                            }
                        }
                    }
                    else if (q == 4)
                    {
                        goto Start;
                    }
                }
                else if (choice == 8)
                {
                start3:
                    Console.WriteLine("By which you want to sort items");
                    Console.WriteLine("1.to sort books");
                    Console.WriteLine("2.to sort CDs");
                    Console.WriteLine("3.to sort DVDs");
                    Console.WriteLine("4.Back");
                    int r = int.Parse(Console.ReadLine());
                    if (r == 1)
                    {
                        Console.WriteLine("1.Sort by Title");
                        Console.WriteLine("2.Sort by Writer");
                        Console.WriteLine("3.Sort by Release Year");
                        Console.WriteLine("4.Back");
                        int r1 = int.Parse(Console.ReadLine());
                        {
                            if (r1 == 1)
                            {
                                Books.SortBooksByTitle(medialist);//calling the method to sort books by title by passing the medialist as parameter
                            }
                            else if (r1 == 2)
                            {
                                Books.SortBooksByWriter(medialist);
                            }
                            else if (r1 == 3)
                            {
                                Books.SortBooksByYear(medialist);
                            }
                            else
                            {
                                goto start3;
                            }
                        }
                    }
                    else if (r == 2)
                    {
                        Console.WriteLine("1.Sort by Title");
                        Console.WriteLine("2.Sort by Singer");
                        Console.WriteLine("3.Sort by Release Year");
                        Console.WriteLine("4.Back");
                        int r2 = int.Parse(Console.ReadLine());
                        {
                            if (r2 == 1)
                            {
                                CD.SortCDsByTitle(medialist);//calling the method to sort cds by title by passing the medialist as parameter
                            }
                            else if (r2 == 2)
                            {
                                CD.SortCDsBySinger(medialist);
                            }
                            else if (r2 == 3)
                            {
                                CD.SortCDsByYear(medialist);
                            }
                            else
                            {
                                goto start3;
                            }
                        }
                    }
                    else if (r == 3)
                    {
                        Console.WriteLine("1.Sort by Title");
                        Console.WriteLine("2.Sort by Director");
                        Console.WriteLine("3.Sort by Release Year");
                        Console.WriteLine("4.Back");
                        int r3 = int.Parse(Console.ReadLine());
                        {
                            if (r3 == 1)
                            {
                                DVD.SortDVDsByTitle(medialist);//calling the method to sort dvds by title by passing the medialist as parameter
                            }
                            else if (r3 == 2)
                            {
                                DVD.SortDVDsByDirector(medialist);
                            }
                            else if (r3 == 3)
                            {
                                DVD.SortDVDsByYear(medialist);
                            }
                            else
                            {
                                goto start3;
                            }
                        }
                    }
                    else if (r == 4)
                    {
                        goto Start;
                    }

                }
                else if (choice == 9)
                {
                start4:
                    Console.WriteLine("By which you want to groupby items");
                    Console.WriteLine("1.to groupby similar books");
                    Console.WriteLine("2.to groupby similar CDs");
                    Console.WriteLine("3.to groupby similar DVDs");
                    Console.WriteLine("4.Back");
                    int g = int.Parse(Console.ReadLine());
                    if (g == 1)
                    {
                        Console.WriteLine("1.grouby genre");
                        Console.WriteLine("2.grouby year");
                        Console.WriteLine("3.Back");
                        int g1 = int.Parse(Console.ReadLine());
                        {
                            if (g1 == 1)
                            {
                                Books.GroupByGenre(medialist);//calling the method to groupby books by genre by passing the medialist as parameter
                            }
                            else if (g1 == 2)
                            {
                                Books.GroupByYear(medialist);
                            }
                            else if (g1 == 3)
                            {
                                goto start4;
                            }
                        }
                    }
                    else if (g == 2)
                    {
                        Console.WriteLine("1.groupby genre");
                        Console.WriteLine("2.groupby year");
                        Console.WriteLine("3.Back");
                        int g2 = int.Parse(Console.ReadLine());
                        {
                            if (g2 == 1)
                            {
                                CD.GroupByGenre(medialist);//calling the method to groupby cds by genre by passing the medialist as parameter
                            }
                            else if (g2 == 2)
                            {
                                CD.GroupByYear(medialist);
                            }
                            else if (g2 == 3)
                            {
                                goto start4;
                            }
                        }
                    }
                    else if (g == 3)
                    {
                        Console.WriteLine("1.groupby genre");
                        Console.WriteLine("2.groupby year");
                        Console.WriteLine("3.Back");
                        int g3 = int.Parse(Console.ReadLine());
                        {
                            if (g3 == 1)
                            {
                                DVD.GroupByGenre(medialist);//calling the method to groupby dvds by genre by passing the medialist as parameter
                            }
                            else if (g3 == 2)
                            {
                                DVD.GroupByYear(medialist);
                            }
                            else if (g3 == 3)
                            {
                                goto start4;
                            }
                        }
                    }
                    else if (g == 4)
                    {
                        goto Start;
                    }
                }
                else if (choice == 10)
                {
                    //showing statistics
                    Console.WriteLine($"The oldest book is published at {Books.FindOldestBook(medialist)}");
                    Console.WriteLine($"The newest book is published at {Books.FindNewestBook(medialist)}");
                    Console.WriteLine($"The oldest CD is published at {CD.FindOldestCD(medialist)}");
                    Console.WriteLine($"The newest CD is published at {CD.FindNewestCD(medialist)}");
                    Console.WriteLine($"The oldest DVD is published at {DVD.OldestDVDYear(medialist)}");
                    Console.WriteLine($"The newest DVD is published at {DVD.NewestDVDYear(medialist)}");
                    Console.WriteLine($"Total books {Books.TotalBookCount(medialist)}");
                    Console.WriteLine($"Total CDs {CD.TotalCDCount(medialist)}");
                    Console.WriteLine($"Total DVDs {DVD.TotalDVDCount(medialist)}");
                    Console.WriteLine($"Total items in the list are {medialist.Count}");
                }
                else if (choice == 11)
                {
                    foreach (Books book in medialist.OfType<Books>())//linq to display all books
                    {
                        book.showdetails();
                    }
                }
                else if (choice == 12)
                {
                    foreach (CD cd in medialist.OfType<CD>())//linq to display all cds
                    {
                        cd.showdetails();
                    }
                }
                else if (choice == 13)
                {
                    foreach (DVD dvd in medialist.OfType<DVD>())//linq to display all dvds
                    {
                        dvd.showdetails();
                    }
                }
                else if (choice == 14)
                {
                 //showing system runtime
                    DateTime birthdate = new DateTime(2023, 10, 25);
                    DateTime now = DateTime.Now;
                    TimeSpan age = now - birthdate;
                    Console.WriteLine($"System is on since {age.Days} days");
                }
                else
                {
                    return;
                }
            }
        }

    }
}
