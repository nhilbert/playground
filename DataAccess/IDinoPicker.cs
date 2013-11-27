using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.DataAccess
{
    public interface IDinoPicker
    {
        List<Dinosaur> getDinosaur();
        List<Species> getSpecies();
    }
}
