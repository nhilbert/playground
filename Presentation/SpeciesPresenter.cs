using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.DataAccess;
using Playground.Model;

namespace Playground.Presentation
{
    public class SpeciesPresenter:CardPresenter
    {
        List<Species> SpeciesList;
      

        public SpeciesPresenter(IDinoPicker MyData):base(new List<ICardable>())
        {
            SpeciesList = MyData.getSpecies();
            foreach(Species thing in SpeciesList){
                _cardObjects.Add(thing);
            }
            ResetEnumerator();
            LoadFromModel();
            Sync();
        }
    }
}
