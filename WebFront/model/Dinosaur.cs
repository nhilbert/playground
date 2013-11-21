using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFront.model
{
    /// <summary>
    /// A Dinosaur is an animal that can be migrated.
    /// </summary>
    public class Dinosaur:IMigratable
    {

        public bool migrated
        {
            get;
            set;
        }

        public void Migrate()
        {
            migrated = true;
        }
    }
}