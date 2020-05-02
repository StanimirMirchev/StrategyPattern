using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class TeamLeaderStrategy : IStrategyPermissions
    {
        private string foreignLanguages;
        private string certificates;
        public TeamLeaderStrategy(string foreignLanguages, string certificates)
        {
            this.foreignLanguages = foreignLanguages;
            this.certificates = certificates;
        }
        public string GivePermissions(string name)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Foreign Languaguages: {0}, Certificates: {1}", this.foreignLanguages, this.certificates);
            result.AppendLine();
            result.AppendFormat("{0} your role is Team Leader and your department is Team Leader department then you are granted with Team Leader permissions!", name);
            return result.ToString();
        }
    }
}
