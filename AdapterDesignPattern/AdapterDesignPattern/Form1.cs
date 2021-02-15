using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AdapterDesignPattern
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
           
        }
       
        IReadData<string> readData1 = new TxtReader { sourcedata = @"c:\DosyaYolu\Sirket2.txt" };
        IReadData<Person> readData2 = new XmlFileReader { sourcedata = @"C:\Users\Ezgi\Desktop\Yazılım Mimarisi ve Tasarımı\AdapterDesignPattern\AdapterDesignPattern\bin\Debug\Person.xml" };
        IReadData<Calısanlar> readData3 = new SqlAdapter();
        private void btnTextFile_Click(object sender, EventArgs e)
        {
            txtlist.DataSource = readData1.GetAll();
        }

        private void btnxmlfile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = readData2.GetAll();
        }

        private void btnsqlveri_Click(object sender, EventArgs e)
        {
            gridveri.DataSource = readData3.GetAll();

            
        }

    }
}
