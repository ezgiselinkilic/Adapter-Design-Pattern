using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AdapterDesignPattern
{
    public class XmlFileReader : IReadData<Person>
    {
        private string _sourcedata;
        public string sourcedata 
        { get { return _sourcedata; }
           set { _sourcedata = value; }
        }
       


        public List<Person> GetAll()
        {
           
            List<Person> p1 = new List<Person>();
            XmlSerializer searial = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs=new FileStream( sourcedata,FileMode.Open,FileAccess.Read))
            {
                p1 = searial.Deserialize(fs) as List<Person>;
            }
            return p1;
        }
       
    }
}
