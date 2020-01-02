using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;



namespace foodMenuMaker
{
   
    public partial class frmMenuMaker : Form
    {

        int recordCnt = 0;
        settingsfrm settingsForm;
        
        public frmMenuMaker()
        {
            InitializeComponent();
            lblNumDataItems.Text =  "0 ITems";
         
            lblFileXMLName.Text=globalVar.getName();
        }



    private void panBurgerInfo_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void butAddItem_Click(object sender, EventArgs e)
        {
            //Check for Errors in txt boxes
            //All Text Boxes must have data before added to Data View

            dataGridView.Rows.Add(cmbMenuType.Text, txtFoodName.Text, txtFoodDescrip.Text, txtFoodPrice.Text);
        }

        private void butClear_Click(object sender, EventArgs e)
        {

            //Clear the Input Txt Fields
            cmbMenuType.Text = ""; txtFoodName.Text = ""; txtFoodDescrip.Text = ""; txtFoodPrice.Text = "";
        }

        private void butCreateXML_Click(object sender, EventArgs e)
        {
           
            XmlWriter xmlW = XmlWriter.Create(globalVar.xmlFilename);
            xmlW.WriteStartDocument();
            xmlW.WriteStartElement("MenuItems");
            recordCnt = dataGridView.Rows.Count-1;
           
            for (int i=0; i < recordCnt; i++)
            {
                xmlW.WriteStartElement("Item");
                xmlW.WriteElementString("FoodType", dataGridView.Rows[i].Cells["clmFoodType"].Value.ToString());
                xmlW.WriteElementString("FoodName", dataGridView.Rows[i].Cells["clmFoodName"].Value.ToString());
                xmlW.WriteElementString("FoodDescrip", dataGridView.Rows[i].Cells["clmFoodDescrip"].Value.ToString());
                xmlW.WriteElementString("FoodPrice", dataGridView.Rows[i].Cells["clmFoodPrice"].Value.ToString());
                xmlW.WriteEndElement();
            }
                              
            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();
            xmlW.Flush();
            xmlW.Close();
            MessageBox.Show("XML File Created and Data Populated","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            //Create an XML file using Data Grid Data.

           
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int cnt = dataGridView.Rows.Count - 1;
            lblNumDataItems.Text = cnt.ToString()+" ITems";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picImageAbout.Visible = true;
        }

        private void frmMenuMaker_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMenuMaker_Click(object sender, EventArgs e)
        {
            picImageAbout.Visible = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = new settingsfrm();
            settingsForm.Show();
        }

        private void picImageAbout_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuMaker_Enter(object sender, EventArgs e)
        {
         
        }

        private void frmMenuMaker_MouseClick(object sender, MouseEventArgs e)
        {
            lblFileXMLName.Text = globalVar.getName();
        }
    }
}
