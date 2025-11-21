using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlanetResearch.Forms
{
    public partial class AddPlanetForm : Form
    {
        public Planet NewPlanet { get; private set; }

        public AddPlanetForm()
        {
            this.BackgroundImage = Image.FromFile("8021306cc8a902b61ffd9103ad880118.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            comboBoxType.DataSource = Enum.GetValues(typeof(PlanetType));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string star = txtStarSystem.Text.Trim();
            double distance = (double)numericDistance.Value;
            PlanetType type = (PlanetType)comboBoxType.SelectedItem;
            double mass = (double)numericMass.Value;
            bool atmosphere = checkBoxAtmosphere.Checked;

            NewPlanet = new Planet(name, star, distance, type, mass, atmosphere);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
