using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            CompanyPermissionsContext permissionsContext = new CompanyPermissionsContext(new RegularWorkerStrategy("Default High School"));
            permissionsContext.AssignPermissions("Default User Name");

            IStrategyPermissions cleanerPermissions = new CleanerStrategy("5");
            IStrategyPermissions hrPermissions = new HRStrategy("organization, communication, conflict management", "2 years in my previous company");
            IStrategyPermissions administrativeWorkerPermissions = new AdministrativeWorkerStrategy("Administrative University of Malta", 36);
            IStrategyPermissions regularWorkerPermissions = new RegularWorkerStrategy("Computer High School");
            IStrategyPermissions teamLeaderPermissions = new TeamLeaderStrategy("English,French,Russian", "Best team lead certificate, Leadership Award");

            permissionsContext.SetPermissions(cleanerPermissions);
            permissionsContext.AssignPermissions("John");

            permissionsContext.SetPermissions(hrPermissions);
            permissionsContext.AssignPermissions("Carolina");

            permissionsContext.SetPermissions(administrativeWorkerPermissions);
            permissionsContext.AssignPermissions("Carolina");

            permissionsContext.SetPermissions(regularWorkerPermissions);
            permissionsContext.AssignPermissions("Frank");

            permissionsContext.SetPermissions(teamLeaderPermissions);
            permissionsContext.AssignPermissions("Frank");
        }
    }
}
