using Assignment_2104001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2104001
{
    internal partial class CD : Media<string>,Ishow//partial class and inherirted from media class and interface
    {
        public string Singer { get; set; }
        public string Producer { get; set; }
        public CD(int ReleaseYear, string Title, string Genre, string Singer, string Producer)
            : base(ReleaseYear, Title, Genre, Singer, Producer)
        {
            this.Singer = Singer;
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
