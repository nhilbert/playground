using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Playground.Model;

namespace Playground.Presentation
{
    public class MigObjectModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IMigratable>().To<Dinosaur>();
        }
    }
}