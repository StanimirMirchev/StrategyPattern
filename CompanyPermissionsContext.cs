using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CompanyPermissionsContext
    {
        private IStrategyPermissions _strategy;
        
        public CompanyPermissionsContext(IStrategyPermissions choosenRoleStrategy)
        {
            _strategy = choosenRoleStrategy;
        }

        public void SetPermissions(IStrategyPermissions choosenRoleStrategy)
        {
            _strategy = choosenRoleStrategy;
        }

        public void AssignPermissions(string name)
        {
            var permissions = _strategy.GivePermissions(name);
            Console.WriteLine(permissions);
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
