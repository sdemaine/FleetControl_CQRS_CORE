using System.Collections.Generic;

namespace FleetControl.Application.Queries.OrgLevelDefinitions
{
    public class GetOrgLevelDefinitionsQueryable_ViewModel
    {
        public IEnumerable<GetOrgLevelDefinitionsQueryable_Dto> OrgLevelDefinitions { get; set; }

        public int TotalCount { get; set; }

        public int GroupCount { get; set; }
    }
}
