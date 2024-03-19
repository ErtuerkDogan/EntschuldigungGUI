using System.Text;
using System.Windows.Forms;

namespace Entschuldigungswriter
{
    public partial class FrmGenerieren : Form
    {
        string entLoc = "C:\\Users\\Dodo\\Desktop\\Entschuldigung.txt";
        string lehrLoc = "C:\\Users\\Dodo\\Desktop\\Lehrername.txt";
        string eigenLoc = "C:\\Users\\Dodo\\Desktop\\Eigenname.txt";

        string lehrerName;
        string eigenName;

        string zeitVon = " ";
        string zeitBis = " ";
        string entschuldigung;


        public FrmGenerieren()
        {
            InitializeComponent();
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }

        private void dtpVon_ValueChanged(object sender, EventArgs e)
        {
            dtpVon.CustomFormat = "dd.mm.yyyy";
            zeitVon = dtpVon.Text.ToString();
        }

        private void dtpBis_ValueChanged(object sender, EventArgs e)
        {
            dtpBis.CustomFormat = "dd.mm.yyyy";
            zeitBis = dtpBis.Text.ToString();
        }

        private void btnGenerieren_Click(object sender, EventArgs e)
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

        private void tbcSGL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEntspeichern_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(new FileStream(entLoc, FileMode.Create), Encoding.UTF8))
            {
                writer.WriteLine(entschuldigung);
            }
        }

        private void FrmGenerieren_Load(object sender, EventArgs e)
        {

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
    }
}