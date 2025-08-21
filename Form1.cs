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
            dgv_teamlist.RowHeadersVisible = false;
            dgv_gameSchedule.RowHeadersVisible = false;
            dgv_result.RowHeadersVisible = false;
        }

        private void frm_homepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superTipsetDataSet.Lag' table. You can move, or remove it, as needed.
            this.lagTableAdapter.Fill(this.superTipsetDataSet.Lag);
            // TODO: This line of code loads data into the 'superTipsetDataSet.Sport' table. You can move, or remove it, as needed.
            this.sportTableAdapter.Fill(this.superTipsetDataSet.Sport);

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S499K0O\\SQLEXPRESS;Initial Catalog=SuperTipset;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            using (SqlCommand cmd = new SqlCommand("SELECT SportID, Sport FROM Sport", conn))
            {
                conn.Open();
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                // Lägg till en rad för placeholder
                DataRow newRow = dt.NewRow();
                newRow["SportID"] = DBNull.Value;   // Ingen riktig ID
                newRow["Sport"] = "Välj sport...";   // Texten som visas
                dt.Rows.InsertAt(newRow, 0);

                // Koppla datan till comboboxen
                cmb_sport.DisplayMember = "Sport";   // vad användaren ser
                cmb_sport.ValueMember = "SportID";  // värdet i bakgrunden
                cmb_sport.DataSource = dt;

                cmb_sport.SelectedIndex = 0; // starta alltid på placeholdern
            }
            dgv_gameSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        //KNAPP SOM NAVIGERAR TILL UNDERFORMULÄR
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_newteams frm_Newteams = new frm_newteams();
            frm_Newteams.Show();
            this.Hide();
        }

        //AVSLUTAKNAPPEN SOM STÄNGER NER APPLIKATIONEN
        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //------------------HÄMTAR LAG FRÅN VALD SPORT I COMBOBOX OCH VISAR I DATAGRIDVIEW----------------
        private void cmb_sport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sport.SelectedIndex == 0 || cmb_sport.SelectedValue == null || cmb_sport.SelectedValue == DBNull.Value)
                return;

            int sportID = (int)cmb_sport.SelectedValue;

            // SQL-fråga för att hämta endast de lag som tillhör vald sport
            string query = "SELECT * FROM Lag WHERE SportID = @Sport";

            //---------ÄNDRA TILL DITT EGNA SERVERNAMN----
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
        private void dgv_teamlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // undvik headern
            {
                // Hämta lagets namn från databasen
                string lagNamn = dgv_teamlist.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Kontrollera om laget redan är valt
                if (txt_team1.Text == lagNamn || txt_team2.Text == lagNamn ||
                    txt_team3.Text == lagNamn || txt_team4.Text == lagNamn)
                {
                    MessageBox.Show("Detta lag är redan valt.");
                    return;
                }

                // Lägg in laget i första lediga textbox
                if (string.IsNullOrEmpty(txt_team1.Text))
                {
                    txt_team1.Text = lagNamn;
                }
                else if (string.IsNullOrEmpty(txt_team2.Text))
                {
                    txt_team2.Text = lagNamn;
                }
                else if (string.IsNullOrEmpty(txt_team3.Text))
                {
                    txt_team3.Text = lagNamn;
                }
                else if (string.IsNullOrEmpty(txt_team4.Text))
                {
                    txt_team4.Text = lagNamn;
                }
                else
                {
                    MessageBox.Show("Du kan bara välja 4 lag.");
                }
            }
        }
        //-----------------------GENERERA SPELSCHEMA---------------------------
        private List<MatchResultat> GenereraSpelschema(string sport, List<string> lag)
        {
            if (lag.Count != 4)
                throw new ArgumentException("Exakt 4 lag måste väljas!");

            var matcher = new List<(string Hemma, string Borta)>
            {
                (lag[0], lag[1]),
                (lag[2], lag[3]),
                (lag[0], lag[2]),
                (lag[1], lag[3]),
                (lag[0], lag[3]),
                (lag[1], lag[2])
            };

            Random rnd = new Random();
            var resultatLista = new List<MatchResultat>();

            foreach (var match in matcher)
            {
                int målHemma = 0, målBorta = 0;

                if (sport == "Ishockey")
                {
                    målHemma = rnd.Next(0, 7);   
                    målBorta = rnd.Next(0, 7);
                }
                else if (sport == "Fotboll")
                {
                    målHemma = rnd.Next(0, 4);   
                    målBorta = rnd.Next(0, 4);
                }
                else if (sport == "Basket")
                {
                    målHemma = rnd.Next(50, 121);
                    målBorta = rnd.Next(50, 121);
                }

                resultatLista.Add(new MatchResultat
                {
                    Hemma = match.Hemma,
                    Borta = match.Borta,
                    MålHemma = målHemma,
                    MålBorta = målBorta
                });
            }

            return resultatLista;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            // Hämta sportens namn från comboboxen
            string sport = cmb_sport.Text;

            // Hämta lag från textboxarna
            var valdaLag = new List<string>
            {
                txt_team1.Text,
                txt_team2.Text,
                txt_team3.Text,
                txt_team4.Text
            };

            // Generera matcher
            var matcher = GenereraSpelschema(sport, valdaLag);

            // Visa i DataGridView (spelschema)
            dgv_gameSchedule.AutoGenerateColumns = true;
            dgv_gameSchedule.DataSource = matcher;
            dgv_result.DataSource = BeräknaTabell(matcher);
        }
        //--------------GENERERA TABELL FÖR MATCHRESULTAT-----------------
        private DataTable BeräknaTabell(List<MatchResultat> matcher)
        {
            // Statistik för varje lag
            var tabell = new Dictionary<string, (int S, int V, int O, int F, int Mplus, int Mminus, int P)>();

            foreach (var match in matcher)
            {
                // Initiera båda lagen om de inte redan finns i tabellen
                if (!tabell.ContainsKey(match.Hemma))
                    tabell[match.Hemma] = (0, 0, 0, 0, 0, 0, 0);
                if (!tabell.ContainsKey(match.Borta))
                    tabell[match.Borta] = (0, 0, 0, 0, 0, 0, 0);

                var hemma = tabell[match.Hemma];
                var borta = tabell[match.Borta];

                // Öka spelade matcher
                hemma.S++;
                borta.S++;

                // Lägg till mål framåt/bakåt
                hemma.Mplus += match.MålHemma;
                hemma.Mminus += match.MålBorta;
                borta.Mplus += match.MålBorta;
                borta.Mminus += match.MålHemma;

                // Avgör resultatet
                if (match.MålHemma > match.MålBorta)
                {
                    hemma.V++; hemma.P += 3;
                    borta.F++;
                }
                else if (match.MålHemma < match.MålBorta)
                {
                    borta.V++; borta.P += 3;
                    hemma.F++;
                }
                else
                {
                    hemma.O++; hemma.P += 1;
                    borta.O++; borta.P += 1;
                }

                // Uppdatera tillbaka till dictionary
                tabell[match.Hemma] = hemma;
                tabell[match.Borta] = borta;
            }

            // Skapa DataTable för att binda till DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Lag", typeof(string));
            dt.Columns.Add("S", typeof(int));
            dt.Columns.Add("V", typeof(int));
            dt.Columns.Add("O", typeof(int));
            dt.Columns.Add("F", typeof(int));
            dt.Columns.Add("M+", typeof(int));
            dt.Columns.Add("M-", typeof(int));
            dt.Columns.Add("P", typeof(int));

            // Lägg till rader sorterat efter poäng (och ev. målskillnad)
            foreach (var lag in tabell
                .OrderByDescending(l => l.Value.P)               // sortera på poäng
                .ThenByDescending(l => l.Value.Mplus - l.Value.Mminus)) // ev. målskillnad som tie-break
            {
                dt.Rows.Add(lag.Key, lag.Value.S, lag.Value.V, lag.Value.O, lag.Value.F,
                            lag.Value.Mplus, lag.Value.Mminus, lag.Value.P);
            }

            return dt;
        }

        //KNAPP FÖR ATT RENSA SPELSCHEMA, RESULTATTABELL, COMBOBOX OCH VALDA LAG
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv_gameSchedule.DataSource=null;
            txt_team1.Text=null;
            txt_team2.Text=null;
            txt_team3.Text=null;
            txt_team4.Text=null;
            dgv_result.DataSource=null;
            dgv_teamlist.DataSource=null;
            cmb_sport.Text = "Välj sport...";
        }
    }
    public class MatchResultat
    {
        public string Hemma { get; set; }
        public string Borta { get; set; }
        public int MålHemma { get; set; }
        public int MålBorta { get; set; }
    }
}