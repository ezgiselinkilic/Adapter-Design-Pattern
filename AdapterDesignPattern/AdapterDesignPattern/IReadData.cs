using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IReadData<T> where T:class
    {
        string sourcedata { get; set; }
        List<T> GetAll();
    }
}
