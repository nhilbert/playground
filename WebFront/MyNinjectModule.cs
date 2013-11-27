using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Playground.Model;

namespace Playground.Presentation
{
    public class MyNinjectModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IMigratableObjectPresenter>().To<MigratableObjectPresenter>();
            Bind<IMigratable>().To<Dinosaur>();
        }
    }
}