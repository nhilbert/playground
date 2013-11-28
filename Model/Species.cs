using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public class Species:ICardable
    {
        public Species() { }

        public Species(String aname) {Name=aname;}

        public Species(String aname, String anURL) 
        {
            Name = aname;
            ImageURL = anURL;
        }

        public String Name { get; set; }
        public String ImageURL { get; set; }
    }
}
