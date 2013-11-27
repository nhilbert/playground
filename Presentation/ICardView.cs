using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Playground.Presentation
{
    public interface ICardView
    {
        String ImageURL { get; set; }
        String Name { get; set; }

        
    }
}
