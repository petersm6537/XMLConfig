using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMLEntry();
        }

        static void XMLEntry()
        {
            XDocument configXML = new XDocument(
    new XComment("This will be my config file for the mold"),
    new XElement("swConfig",
        new XElement("MoldID", "1-123"),
        new XElement("Revision", "PRA1"),
        new XElement("ID", ".625"),
        new XElement("XS", ".075")
    ));

            configXML.Save(@"C:\Users\peter\desktop\configXML");

        }
    }
}
