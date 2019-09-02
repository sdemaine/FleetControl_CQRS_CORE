using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.OrgLevelDefinitions.GetFleetOrgLevelDefinitionList
{
    public class GetFleetOrgLevelDefinitionList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetOrgLevelDefinitionList_Dto> OrgLevelDefinitions { get; }

        public GetFleetOrgLevelDefinitionList_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetOrgLevelDefinitionList_Dto> orgLevelDefinitions) : base(recordCount, previousPage, nextPage)
        {
            OrgLevelDefinitions = orgLevelDefinitions;
        }
    }
}
