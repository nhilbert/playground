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

        public static IMigratableObjectPresenter GetIMigratableObjectPresenter() 
        {
               INinjectSettings settings = new NinjectSettings
                {
                    UseReflectionBasedInjection = true,    // disable code generation for partial trust
                    InjectNonPublic = false,               // disable private reflection for partial trust
                    InjectParentPrivateProperties = false, // reduce magic
                    LoadExtensions = false                 // reduce magic
                };
      
            using (IKernel kernel=new StandardKernel(settings))
            {
                kernel.Load(new MyNinjectModule());
                IMigratableObjectPresenter presenter = kernel.Get<IMigratableObjectPresenter>();
                return presenter;
            }

        }
    }
}