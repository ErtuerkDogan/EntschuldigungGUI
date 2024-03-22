using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Forms;

namespace Entschuldigungswriter
{
    public partial class FrmGenerieren : Form
    {
        string entLoc = "C:\\Users\\Dodo\\Downloads\\Entschuldigung.txt";
        string lehrLoc = "C:\\Users\\Dodo\\Desktop\\Lehrername.txt";
        string eigenLoc = "C:\\Users\\Dodo\\Desktop\\Eigenname.txt";

        string lehrerName;
        string eigenName;

        string zeitVon;
        string zeitBis;
        string entschuldigung;

        bool light = false;


        public FrmGenerieren()
        {
            InitializeComponent();
        }

        private void dtpVon_ValueChanged(object sender, EventArgs e)
        {
            dtpVon.CustomFormat = "dd.MM.yyyy";
            zeitVon = dtpVon.Text.ToString();
            dtpBis.MinDate = dtpVon.Value;
        }

        private void dtpBis_ValueChanged(object sender, EventArgs e)
        {
            dtpBis.CustomFormat = "dd.MM.yyyy";
            zeitBis = dtpBis.Text.ToString();
            dtpVon.MaxDate = dtpBis.Value;
        }

        private void btnLeeren_Click(object sender, EventArgs e)
        { 
            dtpBis.CustomFormat = " ";
            dtpVon.CustomFormat = " ";
        }

        private void btnGenerieren_Click(object sender, EventArgs e)
        {
            if (zeitVon == null && zeitBis == null)
            {
                MessageBox.Show("Kein Datum angegeben");
            }
            else
            {


                using (StreamReader reader = new StreamReader(lehrLoc, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lehrerName = line;
                    }
                }

                using (StreamReader reader = new StreamReader(eigenLoc, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        eigenName = line;
                    }
                }

                entschuldigung = "Sehr geehrte Fr. " + lehrerName + ", \nhiermit entschuldige ich mich, \nda ich vom " + zeitVon + " bis zum " + zeitBis +
                                 " \naus gesundheitlichen Gründen nicht in der Schule war. \nMit freundlichen Grüßen \n" + eigenName;
                lblGeneriert.Text = entschuldigung;
                tbcSGL.SelectedTab = tabPage2;
            }
        }

        private void btnLos_Click(object sender, EventArgs e)
        {
            tbcSGL.SelectedTab = tabPage3;
        }

        private void btnZuruck1_Click(object sender, EventArgs e)
        {
            tbcSGL.SelectedTab = tabPage1;
        }

        private void btnZuruck2_Click(object sender, EventArgs e)
        {
            tbcSGL.SelectedTab = tabPage1;
        }

        private void btnEntspeichern_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(new FileStream(entLoc, FileMode.Create), Encoding.UTF8))
            {
                writer.WriteLine(entschuldigung);
            }
        }

        private void btnLehrer_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(new FileStream(lehrLoc, FileMode.Create), Encoding.UTF8))
            {
                writer.WriteLine(tbxLos.Text);
            }
        }

        private void btnSchueler_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(eigenLoc, FileMode.Create), Encoding.UTF8))
            {
                writer.WriteLine(tbxLos.Text);
            }
        }

        private void cbxLight_CheckedChanged(object sender, EventArgs e)
        {
            light = !light;
            Color Schwarz = Color.Black;
            Color Weiss = Color.Transparent;
            if (light)
            {
                tabPage1.BackColor = Weiss;
                tabPage2.BackColor = Weiss;
                tabPage3.BackColor = Weiss;
                lblTitel.ForeColor = Schwarz;
                lblVon.ForeColor = Schwarz;
                lblBis.ForeColor = Schwarz;
                lblZeitraum.ForeColor = Schwarz;
                lblGrund.ForeColor = Schwarz;
                lblGeneriert.ForeColor = Schwarz;
                lblLos.ForeColor = Schwarz;
                lblNachname.ForeColor = Schwarz;
                cbxLight.ForeColor = Schwarz;

            }

            if (!light)
            {
                tabPage1.BackColor = Color.FromArgb(64, 64, 64);
                tabPage2.BackColor = Color.FromArgb(64, 64, 64);
                tabPage3.BackColor = Color.FromArgb(64, 64, 64);
                lblTitel.ForeColor = Weiss;
                lblVon.ForeColor = Weiss;
                lblBis.ForeColor = Weiss;
                lblZeitraum.ForeColor = Weiss;
                lblGrund.ForeColor = Weiss;
                lblGeneriert.ForeColor = Weiss;
                lblLos.ForeColor = Weiss;
                lblNachname.ForeColor = Weiss;
                cbxLight.ForeColor = Weiss;
            }
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }

        private void FrmGenerieren_Load(object sender, EventArgs e)
        {

        }

        private void tbcSGL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}