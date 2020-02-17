using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Infrastructure.IMappers;
using KarateEvents.ViewModels.ClubViewModels;
using System;

namespace KarateDo.CMS.Mappers.ClubMappers
{
    public class ClubDetailsViewModelMapper : IMapper<AddEditClubViewModel, Club>
    {
        public AddEditClubViewModel From(Club club)
        {
            var vm = new AddEditClubViewModel()
            {
                Id = club.Id,
                Name = club.Name,
                Owner = club.Owner,
                Address = club.Address,
                City = club.City,
                Phone = club.Phone,
                Pib = club.Pib,
            };

            return vm;
        }

        public Club To(AddEditClubViewModel vm)
        {
            var club = new Club()
            {
                Id = vm.Id,
                Name = vm.Name,
                Owner = vm.Owner,
                Address = vm.Address,
                City = vm.City,
                Phone = vm.Phone,
                Pib = vm.Pib,
            };

            if (vm.Id == 0)
            {
                club.DateCreated = DateTime.Now;
                club.DateUpdated = DateTime.Now;
            }
            else 
            {
                club.DateUpdated = DateTime.Now;
            }

            return club;
        }
    }
}