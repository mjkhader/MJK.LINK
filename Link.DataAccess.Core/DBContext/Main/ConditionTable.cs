using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class ConditionTable
    {
        public int ConditionId { get; set; }

        public string Name { get; set; }

        public ICollection<UserCondition> UserConditions { get; set; }
    }
}
