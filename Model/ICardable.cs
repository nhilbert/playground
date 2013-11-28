using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public interface ICardable
    {
        String Name { get; set; }
        String ImageURL { get; set; }
    }
}
