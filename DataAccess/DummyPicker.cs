using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.DataAccess
{
    public class DummyPicker:IDinoPicker
    {
        public List<Model.Dinosaur> getDinosaur()
        {
            List<Dinosaur> ml = new List<Dinosaur>();
            ml.Add(new Dinosaur("Karl-Heinz"));
            ml.Add(new Dinosaur("Frank")); 
            return ml;
        }

        public List<Model.Species> getSpecies()
        {
            List<Species> ml = new List<Species>();
            ml.Add(new Species("Tyrannosaurus","/images/Kentrosaurus.png"));
            ml.Add(new Species("Tarchia", "/images/Tarchia.png"));
            return ml;
        }
    }
}
