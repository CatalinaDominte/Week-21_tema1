using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IReaderRepo<T>
    {
        List<T> Reader(string query);
    }
}
