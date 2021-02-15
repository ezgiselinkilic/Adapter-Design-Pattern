using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class TxtReader : IReadData<string>
    {
        private string _sourcedata;
        public string sourcedata
        {
            get { return _sourcedata; }
            set { _sourcedata = value; }
        }

        public List<string> GetAll()
        {
            List<string> txtlist = new List<string>();
            StreamReader streamReader = File.OpenText(sourcedata);
            string metin;
            while((metin=streamReader.ReadLine())!=null)
            {
                txtlist.Add(metin);
            }
           
            streamReader.Close();
            return txtlist;
        }
    }
}
