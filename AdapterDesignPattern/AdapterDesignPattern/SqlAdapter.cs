using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class SqlAdapter:IReadData<Calısanlar>
    {
        private  SqlReader _drdata=null;
       
       
        public string sourcedata
        {
            get { return _drdata.connectionsource; }
            set { _drdata.connectionsource = value; }
        }
        public List<Calısanlar> GetAll()
        {
           _drdata= new SqlReader {connectionsource= @"server=.;Initial Catalog=Sirket3; integrated security=true" };
            return _drdata.GetAll();
           
        }
    }
}
