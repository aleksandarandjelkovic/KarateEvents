﻿using KarateDo.Infrastructure.IRepositories;
using KarateDo.Infrastructure.IServices;
using KarateDo.Infrastructure.Repositories;
using KarateDo.Infrastructure.Services;
using Ninject;

namespace KarateEvents.WEB.IoC
{
    public class NinjectBindings
    {
        public void Load(IKernel kernel)
        {
            //Services
            kernel.Bind<IClubService>().To<ClubService>();
            kernel.Bind<ICoachService>().To<CoachService>();


            //Repositories
            kernel.Bind<IClubRepository>().To<ClubRepository>();
            kernel.Bind<ICoachRepository>().To<CoachRepository>();
        }
    }
}