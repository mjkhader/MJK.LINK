using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    [Table("Conditions")]
    public class Condition
    {
        [Key]

        public int ConditionId { get; set; }

        public string Name { get; set; }

        public ICollection<UserCondition> UserConditions { get; set; }
    }
}
