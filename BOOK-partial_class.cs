using Assignment_2104001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{

    internal partial class Books : Media<string>,Ishow//partial class and inherirted from media class and interface
    {
        public string Writer { get; set; }
        public string Pages { get; set; }
        public Books(int ReleaseYear, string Title, string Genre, string Writer, string Pages)
            : base(ReleaseYear, Title, Genre, Writer, Pages)
        {
            this.Writer = Writer;
            this.Pages = Pages;
        }

        public  void showdetails()
        {
            base.showdetails();
            Console.WriteLine($"Writer: {property1} Pages: {property2}");
            Console.WriteLine("____________________________________________");
        }

       
    }
}