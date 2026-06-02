using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Core.Base
{
    public interface IBaseRepository <T> where T : class
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

    }
}
