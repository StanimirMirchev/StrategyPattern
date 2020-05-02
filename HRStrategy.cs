using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HRStrategy : IStrategyPermissions
    {   
        private string softSkillsCourses;
        private string coachingExperience;
        public HRStrategy(string softSkillsCourses, string coachingExperience)
        {
            this.softSkillsCourses = softSkillsCourses;
            this.coachingExperience = coachingExperience;
        }

        public string GivePermissions(string name)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Soft skill courses: {0}, Coaching experiance: {1}", this.softSkillsCourses, this.coachingExperience);
            result.AppendLine();
            result.AppendFormat("{0} your role is HR and your department is HR Department then you are granted with HR permissions!", name);
            return result.ToString();
        }
    }
}
