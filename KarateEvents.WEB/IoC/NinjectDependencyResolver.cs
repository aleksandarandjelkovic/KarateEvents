using KarateDo.Infrastructure.IRepositories;
using KarateDo.Infrastructure.Repositories;
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
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IClubRepository>().To<ClubRepository>();
        }
    }
}