using KarateDo.CMS.ViewModels.CoachViewModels;
using KarateDo.Domain.Entities.CoachEntities;
using KarateDo.Infrastructure.Helpers;
using KarateDo.Infrastructure.IMappers;
using KarateEvents.ViewModels.CoachViewModels;
using System.Collections.Generic;

namespace KarateDo.CMS.Mappers.CoachMappers
{
    public class CoachListViewModelMapper : IFromMapper<List<Coach>, CoachesListViewModel>
    {
        public CoachesListViewModel From(List<Coach> coaches) 
        {
            var vm = new CoachesListViewModel();
            var coachesList = new List<CoachViewModel>();

            foreach (var coach in coaches)
            { 
                var newCoach = new CoachViewModel()
                {
                    Id = coach.Id,
                    Name = ValueFormattingHelper.FormatValue(coach.Name),
                    CoachType = ValueFormattingHelper.FormatValue(coach.CoachType.CoachTypeName),
                    Club = ValueFormattingHelper.FormatValue(coach.Club.Name)
                };

                coachesList.Add(newCoach);
            }

            vm.Coaches = coachesList;

            return vm;
        }
    }
}