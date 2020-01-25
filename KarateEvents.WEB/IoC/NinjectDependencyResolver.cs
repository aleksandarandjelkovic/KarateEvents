using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace KarateEvents.WEB.IoC
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();

            var ninjectBindings = new NinjectBindings();
            ninjectBindings.Load(kernel);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}