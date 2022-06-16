using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            /*Entrance to program
            1. Starts form
            2. Sets global variables to the values in the form
            */


            InitializeComponent();
            establishVariableValues();

        }


        public void establishVariableValues()
        {
            /*
             * Sets global variables to the values entered in the form
             * */

            globalVariables.moldID = inputMoldID.Text;
            globalVariables.moldRev = inputRevisionNumber.Text;
            globalVariables.ID = inputID.Value;
            globalVariables.XS = inputXS.Value;

        }

        public void inputVariableValues()
        {
            /*
             * Inserts global variables into the fields in the form
             */

            inputMoldID.Text = globalVariables.moldID;
            inputRevisionNumber.Text = globalVariables.moldRev;
            inputID.Value = globalVariables.ID;
            inputXS.Value = globalVariables.XS;
        }

        static void XMLEntry()
        {
            /*
             * Writes an XML object, then saves it
             */

            XDocument configXML = new XDocument(
            new XComment("This will be my config file for the mold"),
            new XElement("rootElement",
            new XElement("MoldID", globalVariables.moldID),
            new XElement("Revision", globalVariables.moldRev),
            new XElement("ID", globalVariables.ID),
            new XElement("XS", globalVariables.XS)));

            configXML.Save(globalVariables.filePath);

            //Enter savefiledialog here

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"c:\\";
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.AddExtension = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                globalVariables.filePath = saveFileDialog.FileName.ToString();
                configXML.Save(globalVariables.filePath);

            }

        }

        static void XMLRead()
        {
            XDocument configXMLread = XDocument.Load(globalVariables.filePath);

            globalVariables.moldID = configXMLread.Root.Element("MoldID").Value;
            globalVariables.moldRev = configXMLread.Root.Element("Revision").Value;

            try
            {
                globalVariables.ID = Convert.ToDecimal(configXMLread.Root.Element("ID").Value);
                globalVariables.XS = Convert.ToDecimal(configXMLread.Root.Element("XS").Value);
            }
            catch
            {
                globalVariables.ID = .500M;
                globalVariables.XS = .05M;
            }


        }

        static public void SaveFile()
        {
            /*
             * Gets filepath for saving a new XML config
             */

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(importXMLOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                globalVariables.filePath = importXMLOpenFileDialog.FileName;
                XMLRead();
                inputVariableValues();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            establishVariableValues();
            XMLEntry();
        }
    }
}
