using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTipset
{
    public partial class frm_homepage : Form
    {
        public frm_homepage()
        {
            InitializeComponent();
        }

        private void frm_homepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superTipsetDataSet.Lag' table. You can move, or remove it, as needed.
            this.lagTableAdapter.Fill(this.superTipsetDataSet.Lag);
            // TODO: This line of code loads data into the 'superTipsetDataSet.Sport' table. You can move, or remove it, as needed.
            this.sportTableAdapter.Fill(this.superTipsetDataSet.Sport);

        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_newteams frm_Newteams = new frm_newteams();
            frm_Newteams.Show();
            this.Hide();
        }
    }
}
