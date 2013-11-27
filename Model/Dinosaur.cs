﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playground.Model
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

        public string name { get; set; }
        public string imageURL { get; set; }

        public void Migrate()
        {
            migrated = true;
        }
    }
}