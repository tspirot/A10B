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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A10B
{
    public partial class FormUlov : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A10.mdf;Integrated Security=True");
        public FormUlov()
        {
            InitializeComponent();
        }

        private void FormUlov_Load(object sender, EventArgs e)
        {
            PopuniComboPecarosa();
        }
        private void PopuniComboPecarosa()
        {
            string upit = "SELECT PecarosID, " +
                "CONCAT(PecarosID, ' - ', Ime, ' ', Prezime) " +
                "AS ImePrezime FROM Pecaros";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                comboBoxPecaros.DataSource = dt;
                comboBoxPecaros.DisplayMember = "ImePrezime";
                comboBoxPecaros.ValueMember = "PecarosID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string sqlUpit = "SELECT Naziv AS Vrsta, COUNT(Ulov.VrstaID) AS Broj " +
                    "FROM Vrsta_Ribe, Ulov, Pecaros " +
                    "WHERE Ulov.PecarosID = Pecaros.PecarosID " +
                    "AND Pecaros.PecarosID = @param3 " +
                    "AND Ulov.VrstaID = Vrsta_Ribe.VrstaID " +
                    "AND Datum BETWEEN @param1 AND @param2 " +
                    "GROUP BY Naziv";
                SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                komanda.Parameters.AddWithValue("@param1", dateTimePickerOd.Value);
                komanda.Parameters.AddWithValue("@param2", dateTimePickerDo.Value);
                komanda.Parameters.AddWithValue("@param3", comboBoxPecaros.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(komanda);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //konekcija.Close();
                dataGridView1.DataSource = dt;
                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Vrsta";
                chart1.Series[0].YValueMembers = "Broj";
                chart1.Series[0].IsValueShownAsLabel = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
