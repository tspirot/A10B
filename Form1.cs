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

namespace A10B
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A10.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuniComboGradova();
            OsveziListuPecarosa();
        }
        private void OsveziListuPecarosa()
        {
            string upit =
                "SELECT p.PecarosID, p.Ime, p.Prezime, p.Adresa, g.Grad, p.Telefon " +
                "FROM Pecaros AS p, Grad AS g " +
                "WHERE p.GradID=g.GradID";
            SqlCommand cmd = new SqlCommand(upit,konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                dt.Clear();
                listBox1.Items.Clear();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    String red = String.Format(
                        "{0,-6}{1,-15}{2,-15}{3,-20}{4,-15}{5,-15}",
                        dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]
                        );
                    listBox1.Items.Add(red);
                }
                listBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        private void PopuniComboGradova()
        {
            DataTable dtGrad = new DataTable();
            string upit = "SELECT GradID, Grad FROM Grad";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dtGrad);
                comboBoxGrad.DataSource = dtGrad;
                comboBoxGrad.DisplayMember = "Grad";
                comboBoxGrad.ValueMember = "GradID";
                comboBoxGrad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }

        }

        private void toolStripButtonIzmena_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "" || textBoxPrezime.Text == "" 
                || textBoxAdresa.Text == "" || textBoxTelefon.Text == "")
            {
                MessageBox.Show("Morate uneti sve podatke!");
                return;
            }
            if (textBoxSifra.Text == "")
            {
                MessageBox.Show("Morate izabrati red koji zelite da izmenite!");
                return;
            }
            try
            {
                konekcija.Open();
                string sqlIzmena = "UPDATE Pecaros " +
                    "SET Ime = @Ime, Prezime = @Prezime, Adresa = @Adresa, GradID = @Grad, Telefon = @Telefon " +
                    "WHERE PecarosID = @PecarosID";
                SqlCommand komandaIzmena = new SqlCommand(sqlIzmena, konekcija);
                komandaIzmena.Parameters.AddWithValue("@PecarosID", Convert.ToInt32(textBoxSifra.Text));
                komandaIzmena.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                komandaIzmena.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                komandaIzmena.Parameters.AddWithValue("@Adresa", textBoxAdresa.Text);
                komandaIzmena.Parameters.AddWithValue("@Grad", comboBoxGrad.SelectedValue);
                komandaIzmena.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
                komandaIzmena.ExecuteNonQuery();
                int sel = listBox1.SelectedIndex;
                OsveziListuPecarosa();
                listBox1.SelectedIndex = sel;
                MessageBox.Show("Podaci su uspesno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Izmena nija uspela:" + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            FormUlov formUlov = new FormUlov();
            formUlov.ShowDialog();
        }

        private void toolStripButtonIzlaz_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selInd = listBox1.SelectedIndex;
            if(selInd == -1)
                OcistiKontrole();
            else
            {
                DataRow dr = dt.Rows[selInd];
                textBoxSifra.Text = dr[0].ToString();
                textBoxIme.Text = dr[1].ToString();
                textBoxPrezime.Text = dr[2].ToString();
                textBoxAdresa.Text = dr[3].ToString();
                textBoxTelefon.Text = dr[5].ToString();
                comboBoxGrad.Text = dr[4].ToString();
            }
        }
        private void OcistiKontrole()
        {
            textBoxSifra.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxAdresa.Text = "";
            textBoxTelefon.Text = "";
            comboBoxGrad.SelectedIndex = -1;
        }
    }
}
