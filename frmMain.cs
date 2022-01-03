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
    public partial class DGateWay : Form
    {
        public DGateWay()
        {
            InitializeComponent();
            tvTreeView.Nodes[0].Text = "Active";
            //tvTreeView.Nodes[1].Text = "Inactive";


            clDGway dg = new clDGway();
            Array dirs = dg.ReadSch();

            TreeNode rootNode = tvTreeView.Nodes[0];

            for (int x = 0; x <= dirs.Length -1; x++)
            {
                rootNode.Nodes.Add(((string[])dirs)[x]);
            }



            //TreeNode states1 = rootNode.Nodes.Add("Processo 1");
            //TreeNode states2 = rootNode.Nodes.Add("Processo 2");

            //TreeNode rootNode1 = tvTreeView.Nodes[1];
            //TreeNode states11 = rootNode1.Nodes.Add("Processo 3");
            //TreeNode states21 = rootNode1.Nodes.Add("Processo 4");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string pass = "aqio";

        }

        private void tvTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSchedule fr = new frmSchedule();
            fr.Show();
        }

        private void DGateWay_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
