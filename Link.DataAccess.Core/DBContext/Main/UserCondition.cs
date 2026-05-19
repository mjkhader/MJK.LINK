using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class UserCondition
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ConditionId { get; set; }
        public ConditionTable ConditionTable { get; set; }
    }
}
