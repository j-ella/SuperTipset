using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        //Avslutaknappen som stänger ner applikationen
        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Hämtar lag från vald sport i combobox och visar i datagridview
        private void cmb_sport_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hämta sportens ID eller namn från ComboBoxen
            int sportID = Convert.ToInt32 (cmb_sport.SelectedIndex+1);

            // SQL-fråga för att hämta endast de lag som tillhör vald sport
            string query = "SELECT * FROM Lag WHERE SportID = @Sport";
            //string connectionstring = "Data Source=DESKTOP-S499K0O\\SQLEXPRESS;Initial Catalog=SuperTipset;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S499K0O\\SQLEXPRESS;Initial Catalog=SuperTipset;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Sport", sportID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Sätt DataGridView till den filtrerade tabellen
                dgv_teamlist.DataSource = dt;
            }
        }
    }
}
