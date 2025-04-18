using Assignment_2104001;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{
    internal partial class DVD : Media<string>, Ishow//partial class and inherirted from media class and interface
    {
        public string Director { get; set; }
        public string Producer { get; set; }
        public DVD(int ReleaseYear, string Title, string Genre, string Director, string Producer)
            : base(ReleaseYear, Title, Genre, Director, Producer)
        {
            this.Director = Director;
            this.Producer = Producer;
        }

        public void showdetails()
        {
            base.showdetails();
            Console.WriteLine($"Director: {property1} Producer: {property2}");
            Console.WriteLine("____________________________________________");
        }
        
    }


}