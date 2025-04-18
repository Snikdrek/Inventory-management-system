using System;

namespace Assignment_2104001
{
    public interface Ishow
    {
        void showdetails();
    }
    internal class Media<T> : Ishow
    {
        private int releaseYear;
        private string title;
        private string genre;
        protected T property1;
        protected T property2;
       public int ReleaseYear { get=>releaseYear; set=>releaseYear=value; }
        public string Title { get=>title; set=>title=value; }
        public string Genre { get=>genre; set=>genre=value; }
        
        public Media(int ReleaseYear, string Title, string Genre, T property1, T property2)
        {
            this.ReleaseYear = ReleaseYear;
            this.Title = Title;
            this.Genre = Genre;
            this.property1 = property1;
            this.property2 = property2;
        }

        public void showdetails()
        {
            Console.WriteLine($"Release Year: {ReleaseYear} Title: {Title} Genre: {Genre}");
        }
        
    }

   

 
    
}
