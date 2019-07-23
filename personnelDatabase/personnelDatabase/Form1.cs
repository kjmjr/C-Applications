using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personnelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personnelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet1);

        }//end private void 

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }//end of form on load

        private void btnShowRecord_Click(object sender, EventArgs e)
        {

            this.personnelTableAdapter.SearchName
                (this.personnelDataSet1.Personnel, txtSearchName.Text);

            
        }//end btnShowRecord void

    }//end class
}//end namespace
