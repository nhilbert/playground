using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public interface IMigratable
    {
        bool migrated { get; set; }
        void Migrate();
        string name { get; set; }
        string imageURL { get; set; }
    }
}
