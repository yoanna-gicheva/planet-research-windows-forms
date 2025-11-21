using PlanetResearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch.Forms
{
    /// <summary>
    /// Форма за редактиране на съществуваща планета.
    /// Позволява на потребителя да промени свойства като име, маса, тип и наличие на атмосфера.
    /// </summary>
    public partial class EditPlanetForm : Form
    {
        /// <summary>
        /// Връща планетата, която се редактира.
        /// </summary>
        public Interfaces.IPlanet EditedPlanet { get; private set; }

        /// <summary>
        /// Инициализира нова инстанция на <see cref="EditPlanetForm"/> с предварително зададена планета.
        /// Попълва контролните полета с текущите стойности на планетата.
        /// </summary>
        /// <param name="planet">Планетата, която ще бъде редактирана.</param>
        public EditPlanetForm(Interfaces.IPlanet planet)
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

        /// <summary>
        /// Обработва натискането на бутона за запис на промените.
        /// Валидира въведените данни, обновява свойствата на <see cref="EditedPlanet"/> и затваря формата с <see cref="DialogResult.OK"/>.
        /// </summary>
        /// <param name="sender">Обектът, който е изпратил събитието.</param>
        /// <param name="e">Аргументи на събитието.</param>
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
