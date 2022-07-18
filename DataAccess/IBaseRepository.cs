using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace DataAccess
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
    }
}
