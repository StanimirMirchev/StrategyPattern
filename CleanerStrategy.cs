using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CleanerStrategy : IStrategyPermissions
    {   
        private string experience;

        public CleanerStrategy(string experience)
        {
            this.experience = experience;
        }
        
        public string GivePermissions(string name)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Experience in years: {0}", this.experience);
            result.AppendLine();
            result.AppendFormat("{0} your role is Cleaner and your department is Cleaner Department then you are granted with Cleaner permissions!", name);
            return result.ToString();
        }
    }
}
