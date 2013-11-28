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
        /// <summary>
        /// Get a list of all Dinosaurs
        /// </summary>
        /// <returns>A List of Dinosaurs</returns>
        List<Dinosaur> getDinosaur();


        /// <summary>
        /// Get a list of all Species
        /// </summary>
        /// <returns>A List of Species</returns>
        List<Species> getSpecies();
    }
}
