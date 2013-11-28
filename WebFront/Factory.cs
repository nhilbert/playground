using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Playground.Presentation;
using Ninject;

namespace Playground.WebFront
{
    public static class PresenterFactory
    {
        private static INinjectSettings settings = new NinjectSettings
          {
              UseReflectionBasedInjection = true,    // disable code generation for partial trust
              InjectNonPublic = false,               // disable private reflection for partial trust
              InjectParentPrivateProperties = false, // reduce magic
              LoadExtensions = false                 // reduce magic
          };


        public static IMigratableObjectPresenter GetIMigratableObjectPresenter() 
        {
            using (IKernel kernel=new StandardKernel(settings))
            {
                kernel.Load(new MyNinjectModule());
                return kernel.Get<IMigratableObjectPresenter>();
            }
        }

        public static ICardPresenter GetICardPresenter()
        {
            using (IKernel kernel = new StandardKernel(settings))
            {
                kernel.Load(new MyNinjectModule());
                return kernel.Get<ICardPresenter>();
            }
        }
    }
}