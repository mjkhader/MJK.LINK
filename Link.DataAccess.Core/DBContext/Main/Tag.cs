using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<MealTag> MealTags { get; set; }
    }
}
