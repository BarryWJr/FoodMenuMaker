using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodMenuMaker
{
    public partial class settingsfrm : Form
    {
        public settingsfrm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalVar.xmlFilename = txtXMLFileName.Text + ".xml";
            txtXMLFileName.Text = "";
            
        }

        private void settingsfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
