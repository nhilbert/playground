﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFront.model
{
    public interface IMigratable
    {
        bool migrated { get; set; }
        void Migrate();
    }
}
