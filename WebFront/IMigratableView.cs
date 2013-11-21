using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFront
{
    public interface IMigratableView
    {
        Boolean Migrated { get; set; }
    }
}
