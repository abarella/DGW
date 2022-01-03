using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGateWay
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clDGway dg = new clDGway();
            bool _0 = chkDays.GetItemChecked(0);
            bool _1 = chkDays.GetItemChecked(1);
            bool _2 = chkDays.GetItemChecked(2);
            bool _3 = chkDays.GetItemChecked(3);
            bool _4 = chkDays.GetItemChecked(4);
            bool _5 = chkDays.GetItemChecked(5);
            bool _6 = chkDays.GetItemChecked(6);
            dg.AddSch(txtName.Text, txtDesc.Text, chkSchedule.Checked, chkActive.Checked, cmbSchType.Text, mskSchStart.Text, mskSchEnd.Text, mskSchDay.Text, mskSchLoop.Text, mskSchTry.Text, _0, _1, _2, _3, _4, _5, _6);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
