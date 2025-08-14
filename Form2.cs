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
    public partial class frm_newteams : Form
    {
        public frm_newteams()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superTipsetDataSet1.Lag' table. You can move, or remove it, as needed.
            this.lagTableAdapter.Fill(this.superTipsetDataSet1.Lag);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.lagTableAdapter.Update(this.superTipsetDataSet1.Lag);

            frm_homepage homepage = new frm_homepage();
            homepage.Show();
            this.Hide();


        }
    }
}
