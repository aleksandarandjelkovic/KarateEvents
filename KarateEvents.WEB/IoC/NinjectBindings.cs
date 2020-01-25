using KarateDo.Infrastructure.IRepositories;
using KarateDo.Infrastructure.Repositories;
using Ninject;

namespace KarateEvents.WEB.IoC
{
    public class NinjectBindings
    {
        public void Load(IKernel kernel)
        {
            kernel.Bind<IClubRepository>().To<ClubRepository>();
        }
    }
}