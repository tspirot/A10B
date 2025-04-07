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
            OsveziListuPecarosa();
            PopuniComboGradova();
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

        }

        private void toolStripButtonIzmena_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {

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
                textBoxIme.Text = dr[1].ToString();
                textBoxPrezime.Text = dr[2].ToString();
                textBoxAdresa.Text = dr[3].ToString();
                textBoxTelefon.Text = dr[5].ToString();
                comboBoxGrad.SelectedValue = dr[4].ToString();
            }
        }
        private void OcistiKontrole()
        {
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxAdresa.Text = "";
            textBoxTelefon.Text = "";
            comboBoxGrad.SelectedIndex = -1;
        }
    }
}
