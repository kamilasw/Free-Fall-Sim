using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gravity_box
{
    public partial class CreateObject : Form
    {
        public CreateObject()
        {
            InitializeComponent();
        }


        public int getHeightValue()
        {
            return ((int)this.heightValue.Value);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

     
    }
}
