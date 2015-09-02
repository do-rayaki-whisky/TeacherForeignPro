using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherForeignPro
{
    public partial class RemoveDuplicate : Form
    {
        Tool MyTool = new Tool();
        public RemoveDuplicate()
        {
            InitializeComponent();
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            MyTool.RoleRemoveDuplicate(INPUT_PassportNo.Text);
            MessageBox.Show("Status Code " + MyTool.ResultMessage + " OK","Remove Duplicate Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
