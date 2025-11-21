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
    public partial class EditPlanetForm : Form
    {
        public Planet EditedPlanet { get; private set; }

        public EditPlanetForm(Planet planet)
        {
            this.BackgroundImage = Image.FromFile("8021306cc8a902b61ffd9103ad880118.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();

            txtName.Text = planet.Name;
            txtStarSystem.Text = planet.StarSystem;
            numericDistance.Value = (decimal)planet.DistanceFromEarth;
            numericMass.Value = (decimal)planet.Mass;
            comboBoxType.DataSource = Enum.GetValues(typeof(PlanetType));
            comboBoxType.SelectedItem = planet.Type;
            checkBoxAtmosphere.Checked = planet.HasAtmosphere;

            EditedPlanet = planet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Planet name should not be empty!", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStarSystem.Text))
            {
                MessageBox.Show("System should not be empty!", "Error");
                return;
            }

            EditedPlanet.Name = txtName.Text.Trim();
            EditedPlanet.StarSystem = txtStarSystem.Text.Trim();
            EditedPlanet.DistanceFromEarth = (double)numericDistance.Value;
            EditedPlanet.Mass = (double)numericMass.Value;
            EditedPlanet.Type = (PlanetType)comboBoxType.SelectedItem;
            EditedPlanet.HasAtmosphere = checkBoxAtmosphere.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
